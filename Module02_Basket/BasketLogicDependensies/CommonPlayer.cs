using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketPlayers
{
	public class CommonPlayer: BasePlayer
	{
		public string Type;

		public CommonPlayer(string name, string type) : base(name)
		{
			this.Type = type;
		}

        //public override int MakeAttempt()   // не оверрайдим, потому что в метоже ничего не меняется
        //{
        //    int randomNumber = random.Next(40, 140);
        //    return randomNumber;
        //}
    }
}
