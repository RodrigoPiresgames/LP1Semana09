using System;

namespace AnimInterf
{
    public class Bat : Animal, IMammal, IFly
    {
        public int NumberOfWings {get{return 2;} }
        public int NumberOfNipples {get{return 4; } }
        public override string Sound()
        {
            return "Idk man...batman?";
        }
    }
}