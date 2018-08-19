using System;

namespace BasketLogic
{
    public class BasketLogic
    {
       // public int Attempt { get; set; }
       // public int MadeAttemp { get; set; }
        //Random random = new Random();
        //public static int randomNumber;

        public static int[] Attempts { get; set; }

        public void FillMadeAttemptsList()
        {
            int[] MadeAttempts = new int[Attempts.Length + 1];
            Array.Copy(Attempts, MadeAttempts, Attempts.Length);

            Attempts = new int[MadeAttempts.Length];
            Array.Copy(MadeAttempts, Attempts, Attempts.Length);
        }

        //public virtual int MakeAttempt()
        //{
        //    randomNumber = random.Next(40, 140);
        //    return randomNumber;
        //}

        //public virtual int MakeAttempt(int[] Attempts)
        //{
        //    MakeAttempt();
        //    return randomNumber;
        //}
    }
}
