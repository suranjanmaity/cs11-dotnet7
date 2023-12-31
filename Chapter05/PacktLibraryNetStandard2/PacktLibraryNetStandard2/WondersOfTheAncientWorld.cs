﻿namespace Packt.Shared;
[Flags]
/* for performing bitwise operation on enum that will add strings with commma separated
 * and if [Flags]  attribute is not used bitwise operation will give number instead of string
*/
public enum WondersOfTheAncientWorld
{
    None                     = 0b_0000_0000, // i.e. 0
    GreatPyramidOfGiza       = 0b_0000_0001, // i.e. 1
    HangingGardensOfBabylon  = 0b_0000_0010, // i.e. 2
    StatueOfZeusAtOlympia    = 0b_0000_0100, // i.e. 4
    TempleOfArtemisAtEphesus = 0b_0000_1000, // i.e. 8
    MausoleumAtHalicarnassus = 0b_0001_0000, // i.e. 16
    ColossusOfRhodes         = 0b_0010_0000, // i.e. 32
    LighthouseOfAlexandria   = 0b_0100_0000  // i.e. 64
}