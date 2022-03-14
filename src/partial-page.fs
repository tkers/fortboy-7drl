\ like page but skips the top 2 lines
: partial-page
  _SCRN0 SCRN_VY_B 2* + [ SCRN_VX_B SCRN_VY_B 2 - * ]L blank
  0 2 at-xy ;
