\ scaling factor by which all values are scaled out ( to be able to use single celled integers)
10000 constant scaler

\ euler's const 
scaler 28667 10546 */  constant e  

\ pi
scaler 355 113 */ constant pi


\ formatting functions help display constants up to scaler's order beyond decimal point 

\ leave 10s of thousands from the number
: 10thousands  dup scaler / scaler * ;

\ show 4 decinal places, e.g. e mask.4 generates 2.7182
: mask.4 ( n -- n )  dup  scaler / . 8 emit ." ."  dup 10thousands - . ;




