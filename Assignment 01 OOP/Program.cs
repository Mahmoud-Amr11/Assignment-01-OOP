using System.ComponentModel;
using System.Reflection;

namespace Assignment_01_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.
            //WeekDays[] daysOfWeek = (WeekDays[]) Enum.GetValues(typeof(WeekDays));
            //    foreach (WeekDays day in daysOfWeek)
            //    {
            //        Console.WriteLine(day);
            //    }
            #endregion

            #region 2-Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //string name=Console.ReadLine();
            //season s;
            //bool isParsed = Enum.TryParse<season>(name, true, out s);
            //if (isParsed) { 
            //   if (s == season.Spring)
            //    {
            //        Console.WriteLine("Spring: March to May");
            //    }
            //    else if (s == season.Summer)
            //    {
            //        Console.WriteLine("Summer: June to August");
            //    }
            //    else if (s == season.Autumn)
            //    {
            //        Console.WriteLine("Autumn: September to November");
            //    }
            //    else if (s == season.Winter)
            //    {
            //        Console.WriteLine("Winter: December to February");
            //    }

            //}
            #endregion


            #region 3 - Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable
            //Permissions permissions = Permissions.Write | Permissions.Delete; 
            //if((permissions & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Delete permission is allowed.");
            //}
            //if  ((permissions & Permissions.Write) == Permissions.Write)
            //{
            //    Console.WriteLine("Write permission is allowed.");
            //}

            //else
            //{
            //    Console.WriteLine(" permission is not allowed.");
            //}

            #endregion

            #region 4.Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            string c = Console.ReadLine();

            Colors color;
            bool isParsed = Enum.TryParse<Colors>(c, true, out color);

            if (isParsed)
            {
                Console.WriteLine($"{c} is a primary color.");
            }
            else
            {
                Console.WriteLine($"{c} is NOT a primary color.");
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


    enum season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    [Flags]
    enum Permissions :byte
    {
        Read=1,//00000001
        Write =2,//00000010
        Delete =4,//00000100
        Execute = 8//00001000
    }

    enum Colors
    {
        Red,
        Green,
        Blue
    }
}