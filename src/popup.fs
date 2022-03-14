ROM
create bl-bl-3 bl c, bl c, 3 c,
here create popup-frame
bl c, bl c,  5 c,  1 c,  1 c,  1 c,  1 c,  1 c,  1 c,  1 c,  1 c,  1 c,  1 c,  1 c,  1 c,  1 c,  1 c,  6 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,
bl c, bl c,  3 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,  4 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,
bl c, bl c,  3 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,  4 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,
bl c, bl c,  3 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,  4 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,
bl c, bl c,  3 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,  4 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,
bl c, bl c,  3 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,  4 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,
bl c, bl c,  3 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,  4 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,
bl c, bl c,  3 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,  4 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,
bl c, bl c,  3 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,  4 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,
bl c, bl c,  3 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,  4 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,
bl c, bl c,  3 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,  4 c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c, bl c,
bl c, bl c,  7 c,  2 c,  2 c,  2 c,  2 c,  2 c,  2 c,  2 c,  2 c,  2 c,  2 c,  2 c,  2 c,  2 c,  2 c,  8 c,
here swap - constant popup-frame-size
RAM

: .frame
  popup-frame popup-frame-size 0 3 at-xy type
  0 4 at-xy ;

: .tiny ( buf len -- )
  begin
    dup 14 >
  while
    over 14
    begin 1- 2dup + c@ bl = until
    dup 1+ >r
    begin 1- 2dup + c@ bl <> until
    bl-bl-3 3 type 1+ type cr
    r> /string
    cursor-y @ 14 = if
      key drop .frame
    then
  repeat bl-bl-3 3 type type ;

: popup ( c-addr u -- ) page .frame .tiny key drop ;
