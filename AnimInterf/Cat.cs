using System;

    namespace AnimInterf
    {
        public class Cat : Animal, IMammal
        {
            public int NumberOfNipples {get{return 4; } }

            public override string Sound()
            {
                return "Meow Meow";
            }
        }
    }
