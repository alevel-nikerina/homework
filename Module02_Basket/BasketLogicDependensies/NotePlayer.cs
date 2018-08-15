using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketPlayers
{
	class NotePlayer: BasePlayer
	{
		public string Type;

		public NotePlayer(string name, string type) : base(name)
		{
			this.Type = type;
		}

		//public override int Attempt()
		//{
		//	return randomNumber;
		//}
	}
}
