using BasketLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketPlayers
{
	public class NotePlayer: BasePlayer
	{
	    public string Type;

		public NotePlayer(string name, string type) : base(name)
		{
			this.Type = type;
		}

        public static int[] NotePlayerAttempts { get; set; }

        public void FillNotePlayerMadeAttemptsList()
        {
            int[] NotePlayerMadeAttempts = new int[NotePlayerAttempts.Length + 1];
            Array.Copy(NotePlayerAttempts, NotePlayerMadeAttempts, NotePlayerAttempts.Length);

            NotePlayerAttempts = new int[NotePlayerMadeAttempts.Length];
            Array.Copy(NotePlayerMadeAttempts, NotePlayerAttempts, NotePlayerAttempts.Length);
        }

        public override int MakeAttempt()
        {
            randomNumber = random.Next(40, 140);
            {
                for (int i = 0; i < NotePlayerAttempts.Length; i++)
                {
                    if (NotePlayerAttempts[i] == randomNumber)
                    {
                        int newRandomNumber = random.Next(40, 140);
                        randomNumber = newRandomNumber;                       //как убедиться, что для сдедующего рандомного значения снова будет проверяться наличие такого значения в массиве?
                    }

                    else
                        NotePlayerAttempts[i]= randomNumber;
                }

            }
            return randomNumber;
        }
    }
}
