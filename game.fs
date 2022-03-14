title: FortBoy
makercode: TJ

require ./src/textmachine-font.fs

require term.fs
require random.fs
require input.fs
require time.fs

variable initial-seed

require ./src/stars.fs
require ./src/partial-page.fs
require ./src/wrap.fs
require ./src/divider.fs
require ./src/maze.fs
require ./src/intro.fs
require ./src/outro.fs

: reseed ( u -- )
  8 lshift
  rDIV c@ or
  dup seed !
  initial-seed ! ;

: init
  install-font
  init-term
  init-input
  1234 dup seed ! initial-seed ! ;

: title-screen
  stars stars-len type
  7 13 at-xy ." Press"
  6 14 at-xy ." any key"
  key reseed
  5 13 at-xy ." Assembling"
  6 14 at-xy ." Fortress" ;

: main
  init
  begin
    page
    title-screen
    gen-maze
    show-intro
    run-maze
    show-outro
  again ;

\ force emit all code to get correct ROM size
' main drop

\ debugging stats
cr cr
rom here          [host] ." ROM Used: " 5 .r space ." bytes"    [target]
rom here          100 * 32768 / [host] ."  (" 1 .r ." %)"    cr [target]
rom unused        [host] ." ROM Left: " 5 .r space ." bytes" cr [target]
cr
ram 4096 unused - [host] ." RAM Used: " 5 .r space ." bytes"    [target]
ram 4096 unused - 100 * 4096 / [host] ."  (" 1 .r ." %)"     cr [target]
ram unused        [host] ." RAM Left: " 5 .r space ." bytes" cr [target]
