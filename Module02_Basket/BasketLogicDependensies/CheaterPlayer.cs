using BasketPlayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketLogic;

namespace BasketLogicDependensies
{
    public class CheaterPlayer : BasePlayer
    {
        public string Type;

        public CheaterPlayer(string name, string type) : base(name)
        {
            this.Type = type;
        }

        public override int MakeAttempt()
        {
            randomNumber = random.Next(40, 140);
            {
                for (int i = 0; i < BasketLogic.BasketLogic.Attempts.Length; i++)
                {
                    if (BasketLogic.BasketLogic.Attempts[i] == randomNumber)
                    {
                        int newRandomNumber = random.Next(40, 140);
                        randomNumber = newRandomNumber;                       //как убедиться, что для сдедующего рандомного значения снова будет проверяться наличие такого значения в массиве?
                    }

                    else
                        BasketLogic.BasketLogic.Attempts[i] = randomNumber;
                }

            }
            return randomNumber;

        }
    }
}

