require constants.fs


: factorial ( n -- n! )  dup  1 = if  else 1 swap 1 + 1 do i * loop then ;
: exp ( a b -- a^b ) { a b } b 1 = if a else a b  1 do a * loop then ;  

\ e^x Mclauren series based, to 5th member
: e2x ( x -- e^x ) { x } 1   6 1 do 1 x i exp i factorial  */ +  loop ;
