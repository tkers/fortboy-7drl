: /string ( c-addr1 u1 n -- c-addr2 u2 )
  tuck - >r + r> ;

: bounds ( addr u – addr+u addr )
  over + swap ;

: str= ( c-addr1 u1 c-addr2 u2 -- f )
  rot tuck <> if
    drop drop drop false
  else
    0 do
      over c@ over c@ <> if
        drop drop false exit
      then
      1+ swap 1+
    loop
    drop drop true
  then ;
