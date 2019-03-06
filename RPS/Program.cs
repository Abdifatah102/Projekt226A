using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using RPS.Properties;

namespace RPS
{
    
     
    public enum SelectionBase

    {
        Rock,
        Paper,
        Scissors,
        Spock,
        Zombie,
        Lizard,
        Gun
    }


    public abstract class SBase : IComparable<SelectionBase>
    {
        private readonly List<WinningPlay> _winsAgainst;
        
        public SelectionBase(List<WinningPlay> winsAgainst)
        {
            _winsAgainst = winsAgainst;
           



        }
        
        public virtual int CompareTo(SelectionBase other)
        {
            if (GetType() == other.GetType()) return 0; // draws against itself

            if (_winsAgainst.Any(p => p.Winner == other.GetType())) return 1; // wins

            return -1; // otherwise loses.
        }

        public string Name
        {
            get { return GetType().Name; }
        }

        
        public abstract string GetWinningVerb(SelectionBase other);
    }


    public interface IUserInputProvider
    {
        string GetValidUserInput(string prompt, IEnumerable<string> validValues);
    }

    public class ConsoleUserInputProvider : IUserInputProvider
    {
        public string GetValidUserInput(string prompt, IEnumerable<string> validValues)
        {
            var input = string.Empty;
            var isValid = false;
            while (!isValid)
            {
                input = GetUserInput(prompt, validValues);
                isValid = !string.IsNullOrEmpty(input) || validValues.Contains(string.Empty);
            }

            return input;
        }

        private string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        private string GetUserInput(string prompt, IEnumerable<string> validValues)
        {
            var input = GetUserInput(prompt);
            var isValid = validValues.Select(v => v.ToLower()).Contains(input.ToLower());

            return isValid ? input : string.Empty;
        }
    }

    internal class Game
    {
    }
    public class WinningPlay
    {
        public Type Winner { get; private set; }
        public string Verb { get; private set; }

        public WinningPlay(Type type, string verb)
        {
            Winner = type;
            Verb = verb;
        }

    public class Rule
    {
        public readonly SelectionBase Winner;
        public readonly SelectionBase Loser;
        public readonly string WinningPhrase;

        public Rule(SelectionBase Winner, string winningPhrase, SelectionBase loser)
        {
            Winner = this.Winner;
            Loser = loser;
            WinningPhrase = winningPhrase;
        }
        
        private static List<Rule> Rules = new List<Rule>
        {
            new Rule(SelectionBase.Rock, "crushes", SelectionBase.Scissors),
            new Rule(SelectionBase.Spock, "vaporizes", SelectionBase.Rock),
            new Rule(SelectionBase.Paper, "disproves", SelectionBase.Spock),
            new Rule(SelectionBase.Lizard, "eats", SelectionBase.Paper),
            new Rule(SelectionBase.Scissors, "decapitate", SelectionBase.Lizard),
            new Rule(SelectionBase.Spock, "smashes", SelectionBase.Scissors),
            new Rule(SelectionBase.Lizard, "poisons", SelectionBase.Spock),
            new Rule(SelectionBase.Rock, "crushes", SelectionBase.Lizard),
            new Rule(SelectionBase.Paper, "covers", SelectionBase.Rock),
            new Rule(SelectionBase.Scissors, "cut", SelectionBase.Paper)
        };

        private readonly Dictionary<string, SelectionBase> _playable =
            new Dictionary<string, SelectionBase>
            {
                /* {"1", new Rock()},
                {"2", new Paper()},
                {"3", new Scissors()},
                {"4", new Lizard()},
                {"5", new Spock()} */
            };

        public float _winRate;
        public int wins { get; set; }

        protected float winRate
        {
            get { return _winRate; }
            set
            {
                if (value < 0 || value > 100)
                    throw new Exception("Der Wert kann nicht weniger als 0 oder mehr als 100 sein.");

                _winRate = value;
            }
        }


        public static void Menu()
        {
        }

        public void WinRatePrint()
        {
        }
    }
    
    

    internal class Program
    {
        
        
        private static void Main(string[] args)
        {
        int r = (int) SelectionBase.Rock;
        Console.WriteLine(r);

        Console.WriteLine
        ("Willkommen zum Rock, Paper & Scissors Spiel");
        string[] AIchoice = {"rock", "paper", "scissor", "rock", "paper", "scissor"};
        }
}

}
    
}