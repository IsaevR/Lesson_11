using System;

namespace Lesson_11
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            foreach (var d in DateTime.Now.TakeDays(3))
            {
                Console.WriteLine(d);
            }
        }
    }
}
