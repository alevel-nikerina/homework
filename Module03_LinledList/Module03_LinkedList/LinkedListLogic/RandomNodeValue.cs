using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLogic
{
	public class RandomNodeValue
	{
		Random random = new Random();
		public static int randomNumber;

		public int GenerateRandomNodeValue()
		{
			randomNumber = random.Next(0, 100);
			return randomNumber;
		}
	}
}
