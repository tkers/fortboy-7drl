require music.fs
require time.fs

: snd-block
  B4 note 180 ms
  A4 note 180 ms
  C4 note ;

: snd-hooray
  E5  note 120 ms
  A5  note 120 ms
  G5  note 120 ms
  A5  note 60 ms
  E6  note ;

: snd-take
  A5 note 80 ms
  E6 note ;

: snd-drop
  E6 note 80 ms
  A5 note ;

: snd-unlock
  C4 note 60 ms
  A4 note 60 ms
  G5 note ;
