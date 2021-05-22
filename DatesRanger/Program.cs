using DatesRanger.Services;
using System;
using System.Linq;

namespace DatesRanger
{
    class Program
    {
        private static readonly string _wrongAmountOfParaErrorText = "Wrong amount of parameters!";
        private static readonly string _theSameDatesErrorText = "You provided two same dates.";
        private static readonly string _incorrectFirstDateErrorText = "First date is incorrect.";
        private static readonly string _incorrectSecondDateErrorText = "Second date is incorrect.";
        private static bool isDatesCorrect = true;
        private static DatesRangeService _dateRangeService = new DatesRangeService();

        private static void ValidationFailure(string message)
        {
            Console.WriteLine(message);
            isDatesCorrect = false;
        }

        static void Main(string[] args)
        {
            
            DateTime dt1, dt2;

            if (args.Count() == 2)
            {
                if (DateTime.TryParse(args[0], out dt1) == false)
                    ValidationFailure(_incorrectFirstDateErrorText);
                if (DateTime.TryParse(args[1], out dt2) == false)
                    ValidationFailure(_incorrectSecondDateErrorText);
                if (dt1 == dt2)
                    ValidationFailure(_theSameDatesErrorText);

                if (isDatesCorrect)
                {
                    if (dt1 < dt2)
                        Console.WriteLine(_dateRangeService.GetDatesRange(dt1, dt2));
                    else if (dt1 > dt2)
                        Console.WriteLine(_dateRangeService.GetDatesRange(dt2, dt1));
                }


            }
            else ValidationFailure(_wrongAmountOfParaErrorText);
        }
    }
}
