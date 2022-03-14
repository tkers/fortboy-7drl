\ bag to draw random item ids from
8 bag: item-bag
: fill-item-bag 8 item-bag fill-bag ;

: itemid>look
  1- case
    0 of s" You step on something hard: a rusty key." endof
    1 of s" A sword is leaning against the wall." endof
    2 of s" An unlit torch lays long forgotten." endof
    3 of s" You nearly trip over a heavy crowbar." endof
    4 of s" A black cat is napping in the corner." endof
    5 of s" Maah! A bratty goat startles you." endof
    6 of s" A gemstone sparkles in the corner." endof
    7 of s" A box of dynamite awaits its finder." endof
  endcase ;

: itemid>take
  1- case
    0 of s" You pick up the rusty key, almost regretting it as you see the traces of red on your hands. Hopefully it'll be useful." endof
    1 of s" You take the sword. Oof, it's a lot heavier than you thought." endof
    2 of s" You wrap your fingers around the torch, relieved to find out it's still dry and ready for lighting up." endof
    3 of s" You pick up the heavy crowbar. Fighting crime one crowbar at a time!" endof
    4 of s" Despite it never having worked in the past, you crouch down and 'pspsps' from the bottom of your heart. To your surprise, the cat happily runs towards you, your new friend purring loudly." endof
    5 of s" You pull out a half-eaten apple from your pocket, and offer it to the goat. With a hungry 'maaah', the animal decides to follow you." endof
    6 of s" You pick up the gemstone and find yourself hoping you'd get to keep it for yourself. In its purple sparkle it'd surely look beautiful on your bookshelf." endof
    7 of s" You pick up the box of dynamite. Better stay far away from torches for now." endof
  endcase ;

: itemid>drop
  1- case
    0 of s" You drop the rusty key on the floor again." endof
    1 of s" You carefully place the sword against the wall. You might still need it later." endof
    2 of s" You place down the torch next to the wall. You prefer the darkness, anyway." endof
    3 of s" You leave the crowbar behind. Until we meet again, trusty tool!" endof
    4 of s" The cat suddenly sprints away. I guess it was time for dinner?" endof
    5 of s" You toss your half-eaten apple away, and the goat immediately loses interest in you." endof
    6 of s" With a heavy heart, you part ways with the sparkling gemstone." endof
    7 of s" You gently put down the box of dynamite. Easy does it..." endof
  endcase ;

: itemid>use
  1- case
    0 of s" You slide the rusty key into the lock. With a click and a creak the door opens." endof
    1 of s" With a swift strike of your sword, you defeat the rock troll." endof
    2 of s" With your torch lit up, you're ready to conquer the darkness. Watch out, lurking monsters! I'm not afraid anymore." endof
    3 of s" The flimsy door offers no match to your crowbar, and the wood gives in and shatters underneath the tool's force. Watch and learn, burglars!" endof
    4 of s" You gently slide your cat in front of the demonic mouse. The rodent is confident, but all it takes for your cat to defeat it is a gentle push with its paw. The way is cleared and your furry friend falls back asleep in the corner of the room, purring loudly." endof
    5 of s" The dragon wakes up with a huff, and you toss the goat at the yawning creature. You'll be able to slip past it now that the dragon is having its breakfast served in bed. Sorry, goat! Its offended 'maaah' is the last of it you'll ever hear." endof
    6 of s" You take a curious step closer to the door and pull out the heavy gemstone. The sparkling gem slides seamlessly to the spot reserved for it, and in its purple sheen it completes the elegant look. The door silently slides open." endof
    7 of s" You set down the sticks of dynamite, light the fuse and take cover. Fire in the hole! The rock gets blasted into the finest sand." endof
  endcase ;

: itemid>need
  1- case
    0 of s" You try to open the door, but it won't budge. The rusty lock looks too difficult for you to pick." endof
    1 of s" You approach the door, but a rock troll is blocking the way. Better not wake it up..." endof
    2 of s" The path before you is pitch black. You can barely see your own hand. Maybe I should come back here later." endof
    3 of s" The flimsy door shakes on its hinges and you can nearly see through the holes and scratches on it. The lock seems broken, yet despite its flimsiness, the door is stuck." endof
    4 of s" Sudden squeaking and screeching brings a frown to your features. For such a small being, the demonic mouse in front of the door sure does a good job at freaking you out. Maybe I'll come back tomorrow!" endof
    5 of s" A dragon, thrice your size, is blocking your path. Its breathing is warm and heavy, and your knees shake as you fight your urge to run away." endof
    6 of s" The path is blocked by a door crafted from pure gold. In the middle of it two gemstones sparkle elegantly. A space for a third one stands out in its emptiness and the door won't budge." endof
    7 of s" A heavy boulder blocks the doorway and despite your desperate attempts to push it aside, the boulder wins the battle." endof
  endcase ;
