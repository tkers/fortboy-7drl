\ bag to draw random room ids from
24 bag: room-bag
: fill-room-bag 24 room-bag fill-bag ;

: roomid>name
  case
     0 of s" Cellar"         endof
     1 of s" Icey Room"      endof
     2 of s" Library"        endof
     3 of s" Observatory"    endof
     4 of s" Treasury"       endof
     5 of s" Dimly Lit Room" endof
     6 of s" Tower"          endof
     7 of s" Boiler Room"    endof
     8 of s" Art Gallery"    endof
     9 of s" Catacombs"      endof
    10 of s" Attic"          endof
    11 of s" Corridor"       endof
    12 of s" Tunnel"         endof
    13 of s" Hall"           endof
    14 of s" Ballroom"       endof
    15 of s" Dining Room"    endof
    16 of s" Dressing Room"  endof
    17 of s" Chapel"         endof
    18 of s" Pantry"         endof
    19 of s" Lavatory"       endof
    20 of s" Bed Chambers"   endof
    21 of s" Dungeon"        endof
    22 of s" Courtyard"      endof
    23 of s" Nursery"        endof
  endcase ;

: roomid>desc
  case
     0 of s" The sound of bubbling reaches your ears and you see a cauldron in the middle of the room, surrounded by herbs and bones of creatures you've never seen before."  endof
     1 of s" A shiver runs along your spine as the cold wind sweeps through a room completely covered in ice. You nearly slip on the surface, but manage to regain your balance."   endof
     2 of s" Piles of books cover every last corner of the library. If only you had the time to sit in the armchair and dive into the adventures hidden between the dusty covers." endof
     3 of s" The sun, the moon and every last planet of our solar system greet you, as the view to the observatory opens before your eyes. Even the ceiling sparkles with thousands of stars." endof
     4 of s" You squint your eyes, as you get blinded by the sudden brightness of the golden walls around you, adorned by thousands of gemstones."   endof
     5 of s" The room before you is dark as the night, the only light source in it a chandelier in which a single candle flickers faintly. Something about this feels sinister." endof
     6 of s" Soft rustling of something leathery reaches your ears. You notice a hundred bats sleeping right above your head. Please be fruit bats, please be fruit bats..." endof
     7 of s" A loud roar and a puff stops you in your tracks. Is it a zombie? A demon? No, just the boiler room of the castle. Phew."   endof
     8 of s" A room full of life-sized portraits piques your curiosity. The detail in each painting is incredible. You nearly expect to see them move."  endof
     9 of s" Something crunches beneath your feet and you stagger. The floor is uneven-the pile of bones covering every inch not offering a stable ground to walk on."   endof
    10 of s" A small climb later, you find yourself in a dusty attic: the home of badly taxidermied animals with their bead-eyes and matted fur." endof
    11 of s" A long corridor opens before your eyes, its narrow hallway dark and gloomy. The torches on each side of it offer little light." endof
    12 of s" The ceiling of the tunnel is low, and you can barely stand to your full length. Please stay in your webs, spiders! I'm not a fly." endof
    13 of s" It's nothing but a simple hall with dried flower arrangements placed on small tables." endof
    14 of s" The beautiful hall was surely once used to host the most extravagant balls, and you can nearly hear the whisper of the music from the past." endof
    15 of s" A table set for a hundred guests sits empty in the middle of the room. The food remains untouched and the smell of its rot... I'll stick with crackers for now." endof
    16 of s" Pearl necklaces, crowns and lacey dresses lay scattered around the room, and you wonder if once a Queen lived here." endof
    17 of s" Rows after rows of wooden benches sit facing the altar, on which softly flickering candles illuminate a wooden cross." endof
    18 of s" Bags of wheat and barrels of ale cover every last inch of the pantry. Somewhere a small mouse squeaks." endof
    19 of s" The splashing of an overflowing toilet fills the otherwise silent room, and suddenly you wish you had listened to your mother. She always did tell you to become a plumber." endof
    20 of s" A King sized bed stands in the middle of the room, the satin sheets inviting. If it wasn't for the skeleton resting in the midst of them, that is." endof
    21 of s" Clattering chains hang from the ceiling, and the floor beneath feels sticky with something red. People should be more careful when carrying jars of jam." endof
    22 of s" Deep green vines climb along the beautiful statue, its surface tainted grey during the years spent outside. All around it roses of red and pink bloom in their full glory." endof
    23 of s" Sudden goosebumps run along your skin, and soon you spot the reason: the doll in the middle of the room following each of your steps. No thank you!" endof
  endcase ;
