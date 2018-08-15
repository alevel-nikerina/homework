using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLogic
{
	public class BasketLogic
	{
		public int Attempt { get; set; }
		public int MadeAttemp { get; set; }
		Random random = new Random();
		public static int randomNumber;

		public int[] Attempts { get; set; }

		public virtual int [] FillMadeAttemptsList()
		{
			for (int i = 0; i<Attempts.Length; i++)
			return Attempts[i] = random.Next();
		}

		public int[] MadeAttempts  = new int [Attempts.Length]
			for (int j=0; j<MadeAttempts.Lengh; j++)
			MadeAttempts[i] = Attempts[i];
		
			public virtual int MakeAttempt()
			{
				randomNumber = random.Next(40, 140);
				return randomNumber;
			}

		public virtual int MakeAttempt(int [] MadeAttempts)
			{
				randomNumber = random.Next(40, 140);
				for (int q = 0; q < MadeAttempts.Length; q++)
					if (MadeAttempts[q] = randomNumber)
						randomNumber = random.Next(40, 140);
					else
						return randomNumber;
			}
	}
}
