using System;

public class GrowthCalculator
{
    static public void Main ()
    {
        //VARIABLES (Change these to fit your needs)
        int firstDayAmount = 1; //At what point you are at the first day
        int growthPercentage = 1; //Growth percentage on daily basis. Example: read %1 more books than the last day, everyday
        int forHowManyDays = 365; //How many days do you want this calculation to take into account?
        
        //IGNORE
        double currentAmount = firstDayAmount;
        double grandTotal = currentNum;
        
        //ALGORITHM        
        for(int i = 0; i < forHowManyDays; i++)
        {
            currentAmount += (currentAmount * growthPercentage)/100;
            grandTotal += currentAmount; //Keep track of total amount
            
            //OUTPUTTING
            Console.WriteLine((i + 1) + ". Day = " + currentAmount);
        }
        
        //OUTPUTTING FINAL RESULTS
        Console.WriteLine("Grand Total Pages = " + grandTotal);
        
        double dailyAverage = grandTotal / 365;
        Console.WriteLine(dailyAverage);
    }
}
