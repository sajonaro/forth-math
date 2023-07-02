require ttester.fs
require ../functions.fs

\ exponentiation 
T{ 2 3 exp ->  8 }T
T{ 2 1 exp ->  2 }T
T{ 2 10 exp ->  1024 }T


\ factorial
T{ 3 factorial ->  6 }T
T{ 1 factorial ->  1 }T
T{ 10 factorial ->  3628800 }T

." Tests ran successfully" CR