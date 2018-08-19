using BasketPlayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLogicDependensies
{
    public class UberPlayer : BasePlayer
    {
        public string Type;

        public UberPlayer(string name, string type) : base(name)
        {
            this.Type = type;
        }
        public static int[] UberPlayerAttempts { get; set; }

        public override int MakeAttempt()
        {
            {
                for (int i = 0; i < UberPlayerAttempts.Length; i++)
                {
                    if (UberPlayerAttempts.Length == 0)
                    {
                        randomNumber = random.Next(40, 140);
                        UberPlayerAttempts[0] = randomNumber;
                    }

                    else
                    {
                        randomNumber = UberPlayerAttempts[i - 1] + 1;  // правильно???
                        UberPlayerAttempts[i] = randomNumber;
                    }
                }
            }

            return randomNumber;
        }
    }
}
