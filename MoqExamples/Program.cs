using MoqExamples.Domain;
using System;

namespace MoqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ISchoolConfig schoolConfig = new ActualImplementationSchoolConfig();

            School school = new School(schoolConfig);
            Console.WriteLine(school.GetConfigValue("One"));
            Console.WriteLine(school.GetConfigValue("Two"));
            Console.WriteLine(school.GetConfigValue("Three"));
            Console.WriteLine(school.GetConfigValue("Four"));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
