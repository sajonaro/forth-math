: factorial ( n -- n! )  dup  1 = if 1 then 1 swap 1+ 1 do i * loop . ;
: exp ( a b -- a^b ) { a b } a b  1 do a * loop . ;  