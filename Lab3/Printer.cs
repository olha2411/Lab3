using System;
using System.Collections.Generic;
using University.Factories;
using University.Interface;
using University.AbstractLevels;


namespace Lab3
{
    public class Printer
    {
        private readonly ICollection<Student> _students;
        public IFactory Factory { get; set; }
        public ICollection<Student> FilteredStudents { get; set; }
        public Printer(ICollection<Student> students)
        {
            _students = students;
        }

        public void PrintStudents()
        {
            foreach (var student in FilteredStudents)
            {
                Console.WriteLine($"{student.FullName} - semester: {student.Semester}");
                Console.WriteLine(student.ToString());                
            }
            Console.WriteLine();
        }

        private void AddScholarship(Budget student)
        {
            Console.Write("Does student have scholarship? [y - yes/n - no]");
            var answer = Console.ReadKey();
            Console.WriteLine();

            if (answer.Key == ConsoleKey.Y)
            {
                student.HasScholarship = true;
            }
            else
            {
                student.HasScholarship = false;
            }
            
        }

        private void AddStudent()
        {

            Console.WriteLine("Enter form of study(1 - Budget / 2 - Contract)");
            Console.Write("Form Type: ");
            var formTypeStr = Console.ReadLine();
            int formType;

            while (!(int.TryParse(formTypeStr, out formType) && formType > 0 && formType < 3))
            {
                Console.Write("Form Type: ");
                formTypeStr = Console.ReadLine();
            }

            if (formType == 1)
            {
                var student = Factory.CreateBudgetStudent();
                EnterNewStudent(student);
                AddScholarship(student);
                _students.Add(student);
            }
            else if (formType == 2)
            {
                var student = Factory.CreateContractStudent();
                EnterNewStudent(student);
                student.ReplenishAccount(50000);
                AddPayment(student);
                _students.Add(student);
            }
        }

        private void AddPayment(Contract student)
        {
            Console.Write("Make payment now? [y - yes/n - no]");
            var answer = Console.ReadKey();
            Console.WriteLine();

            if (answer.Key == ConsoleKey.Y)
            {
                if (student.CheckPayment())
                {
                    Console.WriteLine("don't need payment");
                }
                else
                {
                    if (student.Pay())
                    {
                        Console.WriteLine("\tpaid");
                    }
                    else Console.WriteLine("\tNot paid. Check score");

                }
            }
            
        }

        private Student EnterNewStudent(Student student)
        {
            Console.Write("Enter FirstName:");
            student.FirstName = Console.ReadLine();
            Console.Write("Enter Surname:");
            student.Surname = Console.ReadLine();
            Console.Write("Enter Patronymic:");
            student.Patronymic = Console.ReadLine();
            Console.Write("Enter Semester:");
            student.Semester = ushort.Parse(Console.ReadLine());
            
            return student;
        }

        public void AddChanges()
        {
            Console.Write("Do you want to add student? [y - yes/n - no] : ");
            var answer = Console.ReadKey();
            Console.WriteLine();

            while (answer.Key == ConsoleKey.Y)
            {
                AddStudent();
                Console.Write("Do you want to add student? [y - yes/n - no] : ");
                answer = Console.ReadKey();
                Console.WriteLine();
            }

        }

    }
}
