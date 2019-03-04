using System;
using System.Collections.Generic;

namespace RPS.Properties
{
   /* public class Rock : SelectionBase
    {
        public override string GetWinningVerb(SelectionBase other)
        {
            if (other is SelectionBase.Scissors) return "crushes";
            if (other is SelectionBase.Lizard) return "crushes";
            if (other is SelectionBase.Zombie) return "trips";

            throw new InvalidOperationException("Is this the same game?");
        }

        public override int CompareTo(SelectionBase other)
        {
            if (other is Rock) return 1;
            if (other is Paper) return 0;
            if (other is Scissors) return -1;
            if (other is Lizard) return -1;
            if (other is Spock) return 1;

            throw new InvalidOperationException("Is this the same game?");
        }
    }
    */
   public class Rock : SelectionBase
   {

       public Rock() 
           : base(new List<WinningPlay>
           {
               new WinningPlay(typeof(), "dents"),
               new WinningPlay(typeof(Lizard), "crushes"),
               new WinningPlay(typeof(Spock), "crushes"),
               new WinningPlay(typeof(), "crushes"),
    
           })
       {
       }
   }

}