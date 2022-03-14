: u>hex-char
  case
    $0 of [char] 0 endof
    $1 of [char] 1 endof
    $2 of [char] 2 endof
    $3 of [char] 3 endof
    $4 of [char] 4 endof
    $5 of [char] 5 endof
    $6 of [char] 6 endof
    $7 of [char] 7 endof
    $8 of [char] 8 endof
    $9 of [char] 9 endof
    $a of [char] a endof
    $b of [char] b endof
    $c of [char] c endof
    $d of [char] d endof
    $e of [char] e endof
    $f of [char] f endof
  endcase ;

: .hex
  dup $f000 and 12 rshift u>hex-char emit
  dup $0f00 and  8 rshift u>hex-char emit
  dup $00f0 and  4 rshift u>hex-char emit
      $000f and           u>hex-char emit ;
