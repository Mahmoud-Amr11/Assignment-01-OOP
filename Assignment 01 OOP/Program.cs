namespace Assignment_01_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.
            WeekDays[] daysOfWeek = (WeekDays[]) Enum.GetValues(typeof(WeekDays));
                foreach (WeekDays day in daysOfWeek)
                {
                    Console.WriteLine(day);
                }
            #endregion
        }

    }
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }
}