using System;

namespace RPS.Properties
{
     public class Scissors : SelectionBase
    {
        public override string GetWinningVerb(SelectionBase other)
        {
            if (other is SelectionBase.Paper) return "cuts";
            if (other is SelectionBase.Lizard) return "decapitates";

            throw new InvalidOperationException("Are we playing the same game?");
        }

        public override int CompareTo(SelectionBase other)
        {
            if (other is Rock) return -1;
            if (other is Scissors) return 0;
            if (other is Lizard) return 1;
            if (other is Spock) return -1;

            throw new InvalidOperationException("Are we playing the same game?");
        }
    } */
}