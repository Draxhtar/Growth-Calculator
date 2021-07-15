using System;

public class GrowthCalculator
{
    static public void Main ()
    {
        //NUMBERS (changeable)
        int firstDayNum = 1; //At what point you are at the first day
        int growthPercentage = 1; //Growth percentage on daily basis. Example: read %1 more books than the last day, everyday
        int forHowManyDays = 365; //How many days do you want this calculation to take into account?
        
        //IGNORE
        double currentNum = firstDayNum;
        double grandTotal = currentNum;
        
        //ALGORITHM        
        for(int i = 0; i < forHowManyDays; i++)
        {
            currentNum += (currentNum * growthPercentage)/100;
            Console.WriteLine((i + 1) + ". Day = " + currentNum);
            grandTotal += currentNum;
        } 
        
        //OUTPUTTING
        Console.WriteLine("Grand Total Pages = " + grandTotal);
        Console.WriteLine(grandTotal / 365); 

    }
}
