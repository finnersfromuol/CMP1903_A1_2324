using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Game
    {
        // Die1: The first dice roll.
        public Die Die1 = new Die();
        // Die2: The second dice roll.
        public Die Die2 = new Die();
        // Die3: The third dice roll.
        public Die Die3 = new Die();
        // DieX: The additional dice roll that does not interfere with the 3 required dice rolls. User can only request this 3 times after initial code.
        public Die DieX = new Die();

        public int result;
        public void DieCreator()
        {
            // "Die1.roll" -> Dice roll stage 1. The first dice roll out of the three.
            Die1.DieValue = Die1.Roll();
            // "result" -> Dice roll stage 1 output. The random number, chosen from 1 to 6.
            result = Die1.DieValue;
            // "Console.WriteLine" -> Outputting the dice roll stage 1 into the console output. Also allowing user to press a key to move onto Dice roll stage 2.
            Console.WriteLine("Dice Roll 1: " + Die1.DieValue + " Now press a key to move onto the next dice roll.");
            Console.ReadKey();

            // "Die2.roll" -> Dice roll stage 2. The second dice roll out of the three.
            Die2.DieValue = Die2.Roll();
            // "result" -> Dice roll stage 2 output. The random number, chosen from 1 to 6. Stage 2
            result = result + Die2.DieValue;
            // "Console.WriteLine" -> Outputting the dice roll stage 2 into the console output. Also allowing user to press a key to move onto Dice roll stage 3.
            // In the background (not visible to frontend) each value is being totalled up. At the end of the code, it will print the total of the 3 dice rolls.
            Console.WriteLine("\nDice Roll 2: " + Die2.DieValue + " Now press a key to move onto the final dice roll.");
            Console.ReadKey();

            // "Die3.roll" -> Dice roll stage 3. The final, last dice roll out of the three.
            Die3.DieValue = Die3.Roll();
            // "result" -> Dice roll stage 3 output. The random number, chosen from 1 to 6. Final dice roll.
            result = result + Die2.DieValue;
            // "Console.WriteLine" -> Outputting the last final dice roll stage 3 into the console output. Also allowing user to press a key to move onto Dice roll stage 3.
            // In the background (not visible to frontend) each value is being totalled up. The next print of code, it will print the total of the 3 dice rolls.
            Console.WriteLine("\nDice Roll 3: " + Die3.DieValue + " Now press a key to view the totalled number from the 3 dice rolls.");
            Console.ReadKey();

            // The total values from all the 3 dice rolls will now printed as "result". This is the final line of code before the application exits.
            Console.WriteLine("\nTotal Dice roll values (totalled): " + result);
            // Pausing the application for 1 second before printing the next message.
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nTo continue rolling a dice for 3 more times (but not being added to the final total), press any key.");
            Console.ReadKey();

            // DiceX is not included in the total printed from code above. This is additional, optional code.
            DieX.DieValue = DieX.Roll();
            Console.WriteLine("\nDice Roll: " + DieX.DieValue);
            Console.ReadKey();

            DieX.DieValue = DieX.Roll();
            Console.WriteLine("\nDice Roll: " + DieX.DieValue);
            Console.ReadKey();

            DieX.DieValue = DieX.Roll();
            Console.WriteLine("\nDice Roll: " + DieX.DieValue);
            // Pausing the application again and alerting the user that this was the last dice roll the application will now close.
            Console.WriteLine("\nThis was the third dice roll. Press any key to end and exit this application.");
            Console.ReadKey();
        }

    }
}
