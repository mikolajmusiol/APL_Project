.data

Max DQ 2147483647
dist DQ 1000 dup(0) ;dist[V]
sptSet DQ 1000 dup(0) ;sptSet[v]

storeVert DQ 0
storeVertM DQ 0
storeArrAdd DQ 0
storeSrc DQ 0
storeGoal DQ 0
storeGraphCell DQ 0
storeDistJ DQ 0
storeDistU DQ 0

u DQ 0

minIdx DQ 0
min DQ 0

.code

MyProc1 PROC

	mov [storeArrAdd], rcx ;save Array Address to memory
	mov [storeVert], rdx ;save # of Vert to memory
	mov [storeVertM], rdx
	dec [storeVertM] ;save # of Vert - 1 to memory
	mov rcx, [storeVert] ;move # of Vert to ecx (counter)
	mov rax, Max ;mov 2147483647 to rax
	mov rbx, OFFSET dist ;move address of dist[] to rbx
	xor rdi, rdi ;Counter = 0
	dec r8 ;?
	dec r9 ;?
	mov [storeSrc], r8 ;starting node?
	mov [storeGoal], r9 ;ending node?

loop1:
	
	mov [rbx+rdi*8], rax ;fill dist[] with 2147483647 (pls no distances bigger than 2147483647)
	inc rdi ;Counter++

loop loop1 ;decrements rcx by 1

	mov rdi, [storeSrc]
	mov rax, OFFSET dist

	mov [rax+rdi*8], rcx ;I don't even remember what this does

	;Outer loop for(int i = 0; i < #ofVert - 1; i++)
	;Inner loop for(int j = 0; j < #ofVert; j++)

	;rcx already is 0 (from previous loop)

	;clear this idk
	mov r8, 0
	mov r9, OFFSET sptSet ;r9 points to sptSet

loop2:

	cmp rcx, [storeVertM]
	je done

	;-----

	call MinDist ;move to rax src of the iteration;

	mov [u], rax

	mov qword ptr [r9+rax*8], 1 ;mark as visited

	;-----

	mov rbx, 0

loop_nest:

	mov rax, [u]
	cmp rbx, [storeVert]
	je nest_done
	;-----

	;!sptSet[j]
	mov rdx, [r9+rbx*8]
	cmp rdx, 0 ;we need 1, e.g. ZF = 1
	jne loop_log

	;dist[u] != Max
	mov r8, OFFSET dist
	mov rdx, [r8+rbx*8]
	mov [storeDistU], rdx
	cmp rdx, Max
	je loop_log

	;graph[u][j] != 0
	mov rdx, [storeVert]
	mul rdx
	add rax, rbx
	mov rdx, 8
	mul rdx
	mov rdx, [storeArrAdd]
	add rax, rdx
	mov [storeGraphCell], rax
	cmp rax, 0
	je loop_log

	;dist[u] + graph[u][j] < dist[j]
	mov rdx, [storeDistU]
	add rax, rdx
	mov rdx, OFFSET dist
	mov r8, [rdx+rbx*8]
	cmp rax, r8
	jae loop_log

	mov rax, [storeDistU]
	add rax, [storeGraphCell]
	mov r8, rax

	;-----

loop_log:
	inc rbx
	jmp loop_nest
	
nest_done:

	inc rcx
	jmp loop2
	
done:
	mov rax, OFFSET dist
	ret
MyProc1 ENDP

;
;

MinDist PROC
	
	mov rax, [Max]
	mov [min], rax
	mov rax, 0
	

loop_dist:
	cmp rax, [storeVert]
	je doneD

	mov rdx, OFFSET sptSet
	mov r8, [rdx+rax*8]
	cmp r8, 0 ;check if (sptSet[v] == false)
	jne false2

	;(sptSet[v] == false) 
	mov rdx, OFFSET dist
	mov r8, [rdx+rax*8]
	mov rdx, [min]
	cmp r8, rdx ;check if (dist[v] <= min)
	jg false2 ;(dist[v] > min)

	;(dist[v] <= min)
	mov rdx, OFFSET dist
	mov r8, [rdx+rax*8]
	mov [min], r8

	mov [minIdx], rax

false2:
	inc rax
	jmp loop_dist

doneD:
	mov rax, [minIdx]
	ret

MinDist ENDP

END