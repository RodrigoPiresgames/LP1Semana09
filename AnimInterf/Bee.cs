using System;

namespace AnimInterf
{
    public class Bee : Animal, IFly
    {
        public int NumberOfWings {get{return 4;} }
        public override string Sound()
        {
            return "Bzzz Bzzzz";
        }
    }

}