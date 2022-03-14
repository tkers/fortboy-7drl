\ screen fits 20x18 = 360 chars
\ 1 kb should fill ~2.8 screens
1024 chars constant pad-size
create pad pad-size allot

: place ( c-addr1 u1 c-addr2 -- )
  over >r rot over cell+ r> move ! ;

: count ( c-addr1 -- c-addr2 u )
  dup cell+ swap @ ;

: append ( c-addr1 u1 c-addr2 -- )
  over over >r >r
  count chars +
  swap chars move
  r> r@ @ + r> ! ;

: cappend ( c c-addr )
  dup @ char+ over !
  count 1- chars + ! ;

: #append ( u c-addr )
  swap
  dup 0< if
    over
    [char] - swap cappend
    0 swap -
  then
  <# #s #> rot append ;
