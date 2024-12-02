;------------------------------------------------------------------------
;.586
.code
;------------------------------------------------------------------------
; Function: AddTwoNumbers
; Takes two 64-bit integers in RCX and RDX and returns their sum in RAX.
;------------------------------------------------------------------------

AddTwoNumbers proc
    mov     rax, rcx        ; Move the first parameter (RCX) into RAX
    add     rax, rdx        ; Add the second parameter (RDX) to RAX
    ret                     ; Return, result is in RAX
AddTwoNumbers endp

END                         ; No entry point
;------------------------------------------------------------------------
