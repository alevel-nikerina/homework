using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLogicDependensies
{
	public class BasePlayer
	{
		public string Name;
		
		Random random = new Random();

		public BasePlayer(string name)
		{
			this.Name = name;
		}

		public virtual int Attempt()
		{
			int randomNumber = random.Next(40, 140);
			return randomNumber;
		}
	}
}
