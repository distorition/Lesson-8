using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleLibriry;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting1 = Properties.Settings.Default.Greating;
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Как вас зовут");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
                Console.WriteLine("Сколько Вам лет ");
                Properties.Settings.Default.Age = Convert.ToInt32(Console.ReadLine());
                Properties.Settings.Default.Save();
                Console.WriteLine("Чем занимаетесь ?");
                Properties.Settings.Default.Busy = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            
            string userName = Properties.Settings.Default.UserName;
            int age = Properties.Settings.Default.Age;
            string busy = Properties.Settings.Default.Busy;
            string greeting = Properties.Settings.Default.Greating;
            Console.Write($"{greeting}, {userName},{age},{busy}!");



        }
    }
}
