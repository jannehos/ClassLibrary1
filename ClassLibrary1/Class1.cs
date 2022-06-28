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


    public bool IsLate(DateTime StartDate, DateTime FinishDate, int EstimatedTimeToMaster)

      {
            TimeSpan studyTime = FinishDate - StartDate;
            int spentTime = studyTime.Days;

            if (spentTime > EstimatedTimeToMaster)
            {
                return true;
            }

            else if (spentTime < EstimatedTimeToMaster)
            {
                return false;
            }

            else if (spentTime == EstimatedTimeToMaster)
            {
                return false;
            }

            return false;
        }

}


    }




    

