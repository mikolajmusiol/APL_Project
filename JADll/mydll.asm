.data
dist DQ 10000 dup(2147483647) ;distance[V]
sptSet DQ 10000 dup(0) ;sptSet[V]

;Storing args
storeVert DQ 0
storeVertM DQ 0
storeArrAdd DQ 0
storeSrc DQ 0
storeGoal DQ 0

u DQ 0

;for MinDist procedure
minIdx DQ 0
min DQ 0

.code
;main
MyProc1 PROC

	;STORING ALL ARGUMENTS
	mov [storeArrAdd], rcx ;save Array Address to memory
	mov [storeVert], rdx ;save # of Vert to memory
	mov [storeVertM], rdx
	dec [storeVertM] ;save # of Vert - 1 to memory
	dec r8
	dec r9
	mov [storeSrc], r8
	mov [storeGoal], r9

	mov rcx, [storeVert] ;move # of Vert to ecx (counter)
	mov rax, 2147483647 ;mov 2147483647 to rax
	mov r8, OFFSET dist ;move address of dist[] to rbx
	mov r9, OFFSET sptSet
	
	;Set up for loop
	mov rcx, 0

;Fill dist[] with MAXs
loopSetDist:
	cmp rcx, [storeVert]
	je finDist
	mov qword ptr [r8+rcx*8], rax
	inc rcx
	jmp loopSetDist

finDist:
	
	;Set up for loop
	mov rcx, 0

;Fill setSpt[] with 0s
loopSetSpt:
	cmp rcx, [storeVert]
	je finSpt
	mov qword ptr [r9+rcx*8], 0
	inc rcx
	jmp loopSetSpt

finSpt:

	;dist[source] = 0
	mov rdi, [storeSrc]
	mov r11, 0
	mov [r8+rdi*8], r11
	
	mov rcx, 0

	;r8 = dist, r9 = sptSet

;Finds the paths for nodes
loop_main:

	cmp rcx, [storeVertM]
	je done

	;Choose the smallest distance from available nodes
	call MinDist ;rax is [minIdx]

	mov rdx, [storeVert]
	mov r10, [storeArrAdd]

	mov qword ptr [r9+rax*8], 1
	mov rbx, 0
	
;Go through the adjacent nodes
loop_nest:

	cmp rbx, [storeVert]
	je next_main
	mov rax, [minIdx]

	;conditional 1 : not in sptSet
	cmp qword ptr [r9+rbx*8], 0
	jne next_inner

	;conditional 3 : check if the distance isnt MAX
	cmp qword ptr [r8+rax*8], 2147483647
	je next_inner

	;conditional 2 : check if there is a connection
	;r10 + (rax * rdx + rbx) * 8 
	mov rdx, [storeVert]
	mul rdx
	add rax, rbx
	mov r11, 8
	mul r11
	add rax, r10
	cmp qword ptr [rax], 0
	je next_inner

	;conditional 4 : src to vert is smaller than the current distance
	mov r11, [minIdx]
	mov r12, [r8+r11*8] ; dist[u] in r12
	add r12, [rax]

	cmp r12, [r8+rbx*8]
	jg next_inner

	;If OK, update the distance[v]
	mov [r8+rbx*8], r12


next_inner:
	inc rbx
	jmp loop_nest

next_main:
	inc rcx
	jmp loop_main

done:
	mov r9, [storeGoal] ;store the end node's index
	mov rax, [r8+r9*8] ;move to rax the value from the index
	ret ;rax returns the value

MyProc1 ENDP


MinDist PROC
	
	;Init value
	mov [min], 2147483647
	mov r11, [storeVert] ;r11 = node count
	xor rax, rax ;rax = 0 (for the loop below)
	
loop_mindist:
	cmp rax, r11
	je done_loop

	;1. cond : sptSet = 0
	mov rdx, OFFSET sptSet
	mov r10, [rdx+rax*8]
	cmp r10, 1
	je loop_it

	;2. cond : distance[v] <= min
	mov rdx, OFFSET dist
	mov r10, [rdx+rax*8]
	cmp r10, [min]
	jg loop_it

	;min = distance[v]
	mov [min], r10

	;min_index = rax
	mov [minIdx], rax

loop_it:
	inc rax
	jmp loop_mindist

done_loop:
	mov rax, [minIdx]
	ret

MinDist ENDP

END