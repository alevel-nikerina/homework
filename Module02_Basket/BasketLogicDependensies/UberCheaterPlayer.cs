using BasketPlayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLogicDependensies
{
   public class UberCheaterPlayer: BasePlayer
    {
        public string Type;

        public UberCheaterPlayer(string name, string type) : base(name)
        {
            this.Type = type;
        }
        public static int[] UberPlayerAttempts { get; set; }

        public override int MakeAttempt()
        {

        }
    }
}
