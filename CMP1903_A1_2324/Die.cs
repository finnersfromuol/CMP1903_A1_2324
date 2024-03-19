using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Die
    {
        // "DieValue" -> This will hold the value of the dice each time it is randomised and printed into the console. By default, at the start will remain at 0.
        public int DieValue = 0;

        public int Roll()
        {
            // "Random rnd" -> This will generate a random number from 1 to 6.
            Random rnd = new Random();
            int ReturnValue = rnd.Next(1, 7);
            // "return ReturnValue" -> This will return into the console, the number that was randomly generated.
            return ReturnValue;
        }
    }
}
