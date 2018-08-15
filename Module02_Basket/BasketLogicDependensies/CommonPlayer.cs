using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLogicDependensies
{
	public class CommonPlayer: BasePlayer
	{
		public string Type;

		public CommonPlayer(string name, string type) : base(name)
		{
			this.Type = type;
		}

		public override int Attempt()
		{
			int randomNumber = random.Next(40, 140);
			return randomNumber;
		}
	}
}
