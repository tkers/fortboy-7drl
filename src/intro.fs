require ./hero.fs

: month
  12 random case
    0 of s" January" endof
    1 of s" February" endof
    2 of s" March" endof
    3 of s" April" endof
    4 of s" May" endof
    5 of s" June" endof
    6 of s" July" endof
    7 of s" August" endof
    8 of s" September" endof
    9 of s" October" endof
   10 of s" November" endof
   11 of s" December" endof
  endcase ;

: state-of-being
  6 random case
    0 of s" bounding headache" endof
    1 of s" deep frown" endof
    2 of s" soft gasp" endof
    3 of s" big yawn" endof
    4 of s" small shiver" endof
    5 of s" flinch" endof
  endcase ;

: atmosphere
  7 random case
    0 of s" large and frightening" endof
    1 of s" vast and daunting" endof
    2 of s" dark and petrifying" endof
    3 of s" gloomy and menacing" endof
    4 of s" ill-lit and cold" endof
    5 of s" sinister and cobwebbed" endof
    6 of s" dusty and bleak" endof
endcase ;

: state-of-mind
  6 random case
    0 of s" eye lids feel heavy" endof
    1 of s" vision is blurred" endof
    2 of s" thoughts are clouded" endof
    3 of s" head feels empty" endof
    4 of s" stomach rumbles" endof
    5 of s" head is spinning" endof
  endcase ;

: show-intro
  page
  \ date header
  0 pad !
  30 random 1+ pad #append
  bl pad cappend
  month pad append
  bl pad cappend
  667 random 1203 + pad #append
  pad count center type cr
  =====

  s" You wake up with a " pad place
  state-of-being pad append
  s"  in a " pad append
  atmosphere pad append
  s"  fortress. Your " pad append
  state-of-mind pad append
  s" , and the only thing you can remember is your name: " pad append
  first-name pad append
  bl pad cappend
  last-name-1 pad append
  last-name-2 pad append
  [char] . pad cappend
  bl pad cappend

  pad count .wrapped
  key drop partial-page

  s" Being a simple " pad place
  profession pad append
  s" , you have no reason to be in this strange place. Better take a look around and unravel this mystery. Be brave, unlikely hero. Adventure awaits!" pad append
  pad count .wrapped
  key drop ;
