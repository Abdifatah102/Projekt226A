using System.Collections.Generic;
namespace RPS.Properties

{
    public class Paper : SelectionBase
    {
        public Paper()
            : base(new List<WinningPlay>
            {
                new WinningPlay(typeof (Rock), "covers"),
                new WinningPlay(typeof (Spock), "disproves")
            })
        {
        }
    }

}