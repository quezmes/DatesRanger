using DatesRanger.Services;
using System;
using System.Linq;

namespace DatesRanger
{
    class Program
    {
        private static readonly string _incorrectFirstDateErrorText = "First date is incorrect.";
        private static readonly string _incorrectSecondDateErrorText = "Second date is incorrect.";
        private static DatesRangeService _dateRangeService = new DatesRangeService();

        static void Main(string[] args)
        {
            bool isDatesCorrect = true;
            DateTime dt1, dt2;

            if (args.Count() == 2)
            {
                if (DateTime.TryParse(args[0], out dt1) == false)
                {
                    Console.WriteLine(_incorrectFirstDateErrorText);
                    isDatesCorrect = false;
                }
                if (DateTime.TryParse(args[1], out dt2) == false)
                {
                    Console.WriteLine(_incorrectSecondDateErrorText);
                }
                if (isDatesCorrect)
                {
                    if (dt1 < dt2)
                        Console.WriteLine(_dateRangeService.GetDatesRange(dt1, dt2));
                    else if (dt1 > dt2)
                        Console.WriteLine(_dateRangeService.GetDatesRange(dt2, dt1));
                }


            }
            else Console.WriteLine("Wrong amount of parameters!");
            Console.WriteLine("Hello World!");
        }
    }
}
