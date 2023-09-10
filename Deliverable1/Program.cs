using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Restocking Tool");

        //Declaring some of the starting variables I'll need here
        int SodaStock = 100;
        int ChipsStock = 40;
        int CandyStock = 60;
        int SodaRestock = 40;
        int ChipsRestock = 20;
        int CandyRestock = 40;

        //Determining Soda stock
        Console.WriteLine("How many Sodas have been sold today? " + SodaStock + " are in stock.");
        string SodaAnswer = Console.ReadLine();
        int SodasSold = int.Parse(SodaAnswer);
        if (SodasSold > SodaStock)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        else
        {
            Console.WriteLine("There are " + (SodaStock - SodasSold) + " Sodas left.");
        }

        //Determining Chips stock
        Console.WriteLine("How many Chips have been sold today? " + ChipsStock + " are in stock.");
        string ChipsAnswer = Console.ReadLine();
        int ChipsSold = int.Parse(ChipsAnswer);
        if (ChipsSold > ChipsStock)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        else
        {
            Console.WriteLine("There are " + (ChipsStock - ChipsSold) + " Chips left.");
        }

        //Determining Candy stock
        Console.WriteLine("How many Candy have been sold today? " + CandyStock + " are in stock.");
        string CandyAnswer = Console.ReadLine();
        int CandySold = int.Parse(CandyAnswer);
        if (CandySold > CandyStock)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        else
        {
            Console.WriteLine("There are " + (CandyStock - CandySold) + " Candy left.");
        }

        // This is where I'll figure out the restocks. Added the && in the if 
        // conditions so the restock message will not display with an invald entry.
        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked:");
        if (SodaStock - SodasSold <= SodaRestock && SodasSold <= 100)
        {
            Console.WriteLine("Soda needs to be restocked.");
        }
        if (ChipsStock - ChipsSold <= ChipsRestock && ChipsSold <= 40)
        {
            Console.WriteLine("Chips need to be restocked.");
        }
        if (CandyStock - CandySold <= CandyRestock && CandySold <= 60)
        {
            Console.WriteLine("Candy needs to be restocked.");
        }
        Console.WriteLine("Goodbye!");
    }
}
