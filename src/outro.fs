: show-outro
  page
  s" Outside" center type cr
  =====
  s" You squint your eyes at the sudden change in brightness. You're back outside! The adventure " pad place
  gold-coins @ ?dup 0= if
    s" behind you is " pad append
  else
    s" is behind you, " pad append
    dup 1 = if
      drop
      s" and the gold coin in your pocket is " pad append
    else
      s" and the " pad append
      pad #append
      bl pad cappend
      s" gold coins in your pocket are " pad append
    then
  then
  s" the only proof that any of it was real in the first place. Or was it? The memories are already starting to fade..." pad append
  pad count .wrapped
  key drop
  page
  2 8 at-xy ." You made it out!"
  3 9 at-xy ." Gold coins: " gold-coins ?
  snd-hooray
  key drop ;
