namespace Mission2;

public class SecondClass
{
    public int[] RandomRolls(int desiredRolls, int[]diceTracker)
    {
        // this method randomly generates the roll outcome for each dice and then appends 
        //the sum of the rolls to the diceTracker array
        for (int i = 0; i < desiredRolls; i++)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int rollOutcome = dice1 + dice2;
            diceTracker[rollOutcome]++;
        }
        //prints the asterisks
        for (int i = 2; i < diceTracker.Length; i++)
        {
            // this calculates the percentage of times a number was rolled
            int numAsterisks = 100 * diceTracker[i] / desiredRolls;
            
            System.Console.WriteLine((i) + ": ");
            
            // this for loop will create an asterisk for every percent that a number was rolled out of the total rolls
            for (int j = 0; j < numAsterisks; j++)
            { 
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        return diceTracker;

    }
}