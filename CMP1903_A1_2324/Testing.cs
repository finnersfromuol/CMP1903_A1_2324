using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Testing
    {
        public void Test()
        {
            // "DiceTest" object for testing this dice game.
            Game DiceTest = new Game();

            DiceTest.DieCreator();

            // The code below will act like you are running the game real time. It will randomly generate a number and print it.
            Die DieTest = new Die();
            DieTest.DieValue = DieTest.Roll();
            // Dice will randomly generate a number and print it.
            Console.WriteLine("\nDice Test: " + DieTest.DieValue);
            Console.WriteLine("Press any key to exit...");

            // Testing the value choices which should be above 0 and below 7 at all times the dice is rolled.
            Debug.Assert(DieTest.DieValue > 0 && DieTest.DieValue < 7);
            // Totalling the 3 dice rolls and then printing the totalled combined from each one.
            Debug.Assert(DiceTest.result == DiceTest.Die1.DieValue + DiceTest.Die2.DieValue + DiceTest.Die3.DieValue);

            // Testing the additional, 3 dice rolls (Which are not totalled in the initial 3, essential die rolls)
            Debug.Assert(DiceTest.result == DiceTest.DieX.DieValue);
        }
    }
}
