using System;

namespace Class1
{
    class Class2
    {
        public enum weekDays
        {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY

        }
        weekDays dayOne = weekDays.MONDAY;
        weekDays dayTwo = weekDays.TUESDAY;
        weekDays dayThree = weekDays.WEDNESDAY;
        weekDays dayFour = weekDays.THURSDAY;
        weekDays dayFive = weekDays.FRIDAY;
        weekDays daySixteenth = weekDays.SATURDAY;
        weekDays daySeventeenth = weekDays.SUNDAY;
        static void Main(string[] args)
        {
            foreach (int i in Enum.GetValues(typeof(weekDays)))
                Console.WriteLine(Enum.GetName(typeof(weekDays), i));
          
          
            Console.ReadKey();
        }
    }
}