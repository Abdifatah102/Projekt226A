using System;
using System.Collections.Generic;

namespace RPS.Properties
{
    public class Rock : SelectionBase
    {
        public string GetWinningVerb(SelectionBase other)
        {
            if (other is Scissors) return "crushes";
            if (other is Lizard) return "crushes";
            if (other is Zombie) return "trips";

            throw new InvalidOperationException("Is this the same game?");
        }

        public int CompareTo(SelectionBase other)
        {
            if (other is Rock) return 1;
            if (other is Paper) return 0;
            if (other is Scissors) return -1;
            if (other is Lizard) return -1;
            if (other is Spock) return 1;

            throw new InvalidOperationException("Is this the same game?");
        }
    }
    
    public partial class { Rock() 
    : base(new List<WinningPlay>
    {
    new WinningPlay(typeof(Scissors), "crushes"),
    new WinningPlay(typeof(Lizard), "crushes")
    })
    }



   /*public class Rock : SelectionBase
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
   } */

}