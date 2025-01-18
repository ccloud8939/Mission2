// See https://aka.ms/new-console-template for more information

// Name: Chloe CLoud
// Section: 001
// Description: This program allows the user to role 2 die however many times they indicate 
// and then see the percetage of times they rolled any number of combinations
using Mission2;

public class DiceGame
{
    private static void Main(string[] args)
    {
        // this is creating an variable to store the user's input of how many rolls they would like
        int desiredRolls = 0;
        
        // this is welcoming the user
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        // Question to ask the user how many times they want to roll
        System.Console.WriteLine("How many times would you like to roll?");
        
        // This line is reading the response from the user 
        desiredRolls = int.Parse(System.Console.ReadLine());
        
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        
        System.Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        
        System.Console.WriteLine("Total Number of rolls = " + desiredRolls);
        
        int[] diceTracker = new int[13];
        // this is the instance from the SecondClass class 
        SecondClass sc = new SecondClass();
        // this calls the instace and RandomRolls method from the second class
        sc.RandomRolls(desiredRolls, diceTracker);
    }
}