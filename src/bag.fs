(
  Usage:

  Define a bag at compile-time:
  10 bag: my-bag

  Fill it with 0..9 numbers at run-time:
  10 my-bag fill-bag

  Draw a unique random number:
  room-bag draw-bag
)

:m bag: create 1+ cells allot ;

\ : empty-bag ( bag -- ) 0 ! ;
: bag-empty? ( bag -- f ) @ 0 = ;

: fill-bag ( u bag -- )
  2dup !
  cell+
  2dup
  swap 0 do
    I over !
    cell+
  loop
  drop
  swap shuffle ;

: draw-bag ( bag -- u )
  -1 over +!
  dup @ 1+
  cells + @ ;
