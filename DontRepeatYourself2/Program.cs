using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontRepeatYourself2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a numerical selection:");
            Console.WriteLine("1 - View Students");
            Console.WriteLine("2 - View Available Resources");
            Console.WriteLine("3 - View Student Accounts");
            Console.WriteLine("4 - Exit");
            var selectedAction = Console.ReadLine();
            SelectItem(selectedAction);
        }

        static void SelectItem(string menuSelection)
        {
            switch (menuSelection)
            {
                case "1":
                    Console.Clear();
                    ViewStudents();
                    break;
                case "2":
                    Console.Clear();
                    ViewResources();
                    break;
                case "3":
                    Console.Clear();
                    ViewAccounts();
                    break;
                case "4":
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("I'm sorry, that's not a valid selection. ");
                    Console.WriteLine("");
                    Console.WriteLine("Please enter a numerical selection:");
                    Console.WriteLine("1 - View Students");
                    Console.WriteLine("2 - View Available Resources");
                    Console.WriteLine("3 - View Student Accounts");
                    Console.WriteLine("4 - Exit");
                    var selectedAction = Console.ReadLine();
                    SelectItem(selectedAction);
                    break;
            }
        }

        static void ViewStudents()
        {
            Console.WriteLine("Ahmed");
            Console.WriteLine("Robert");
            Console.WriteLine("Sue");
            Console.WriteLine("Catherine");
            Console.WriteLine("Jitinder");
            Console.WriteLine("James");
            Console.WriteLine("Rihanna");
            Console.WriteLine("");
            Console.WriteLine("Please enter a numerical selection:");
            Console.WriteLine("1 - View Students");
            Console.WriteLine("2 - View Available Resources");
            Console.WriteLine("3 - View Student Accounts");
            Console.WriteLine("4 - Exit");
            var selectedAction = Console.ReadLine();
            SelectItem(selectedAction);
        }

        static void ViewResources()
        {
            Console.WriteLine("Ahmed - £50.01");
            Console.WriteLine("Robert - £36.79");
            Console.WriteLine("Sue - £114.12");
            Console.WriteLine("Catherine - £58.21");
            Console.WriteLine("Jitinder - £9.70");
            Console.WriteLine("James - £102.30");
            Console.WriteLine("Rihanna - £78.54");
            Console.WriteLine("");
            Console.WriteLine("Please enter a numerical selection:");
            Console.WriteLine("1 - View Students");
            Console.WriteLine("2 - View Available Resources");
            Console.WriteLine("3 - View Student Accounts");
            Console.WriteLine("4 - Exit");
            var selectedAction = Console.ReadLine();
            SelectItem(selectedAction);
        }

        static void ViewAccounts()
        {
            Console.WriteLine("Library");
            Console.WriteLine("Printer 1");
            Console.WriteLine("Printer 2");
            Console.WriteLine("Meeting Room 1");
            Console.WriteLine("Meeting Room 2");
            Console.WriteLine("Conference Room 1");
            Console.WriteLine("");
            Console.WriteLine("Please enter a numerical selection:");
            Console.WriteLine("1 - View Students");
            Console.WriteLine("2 - View Available Resources");
            Console.WriteLine("3 - View Student Accounts");
            Console.WriteLine("4 - Exit");
            var selectedAction = Console.ReadLine();
            SelectItem(selectedAction);
        }
    }
}
