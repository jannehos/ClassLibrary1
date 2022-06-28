using System;

namespace ClassLibrary1
{
    public class DayCalculation
    {
           

    public bool IsFuture(DateTime CompletionDate)
    {

        DateTime Today = DateTime.Now;


        if (CompletionDate > Today)
        {

            return true;

        }
        else if (CompletionDate < Today)
        {
            return false;
        }

        return false;

    }

}


 }




    

