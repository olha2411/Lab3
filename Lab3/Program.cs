using System;
using System.Linq;
using University.Factories;
using University.Students.BudgetStudents;
using University.Students.ContractStudents;

namespace Lab3
{    
    class Program
    {
       static void Main(string[] args)
        {
            var data = new Data();
            var students = data.Students;
            Printer printer;
            int levelType;

            Console.Write("Do you want to continue? [y - yes/n - no] : ");
            var answer = Console.ReadKey();
            Console.WriteLine();           

            while (answer.Key == ConsoleKey.Y)
            {
                Console.WriteLine("\tGet all students by level");
                Console.WriteLine("Enter level type (1 - Bachelor/2 -  Master/3 - PhD/ 0 - end)");
                Console.Write("Level Type: ");
                var levelTypeStr = Console.ReadLine();
                while(!int.TryParse(levelTypeStr, out levelType))
                {
                    Console.Write("Level Type: ");
                    levelTypeStr = Console.ReadLine();
                }
                printer = new Printer(students);

                switch (levelType)
                {
                    case 1:
                        printer.Factory = new BachelorFactory();
                        printer.FilteredStudents = students.Where(s => s is BudgetBachelor || s is ContractBachelor).ToList();
                        printer.PrintStudents();
                        printer.AddChanges();
                        break;
                    case 2:
                        printer.Factory = new MasterFactory();
                        printer.FilteredStudents = students.Where(s => s is BudgetMaster || s is ContractMaster).ToList();
                        printer.PrintStudents();
                        printer.AddChanges();
                        break;
                    case 3:
                        printer.Factory = new PhDFactory();
                        printer.FilteredStudents = students.Where(s => s is BudgetPhD || s is ContractPhD).ToList();
                        printer.PrintStudents();
                        printer.AddChanges();
                        break;
                    case 0:
                        break;
                }

                Console.Write("Do you want to continue? [y - yes/n - no] : ");
                answer = Console.ReadKey();
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }

    }
}
