using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketPlayers
{
	public abstract class BasePlayer
	{
        protected Random random = new Random();
        public int randomNumber;
        public string Name;

		public BasePlayer(string name)
		{
			this.Name = name;
		}

        public virtual int MakeAttempt()
        {
            randomNumber = random.Next(40, 140);
            return randomNumber;
        }

        public virtual int MakeAttempt(int[] Attempts)
        {
            MakeAttempt();
            return randomNumber;
        }
    }
}
