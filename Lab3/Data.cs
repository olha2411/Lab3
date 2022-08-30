using System.Collections.Generic;
using University.AbstractLevels;
using University.Students.BudgetStudents;
using University.Students.ContractStudents;

namespace Lab3
{
    public class Data
    {
        public List<Student> Students = new List<Student>
       {
           new BudgetBachelor
           {
               FirstName = "Vitaliy",
               Surname = "Pavlenko",
               Patronymic = "Viktorivych",
               Semester = 5,
               HasScholarship = false,
           },

           new BudgetMaster
           {
               FirstName = "Ivan",
               Surname = "Pavluk",
               Patronymic = "Valeriiovych",
               Semester = 1,
               HasScholarship = true,
           },

           new BudgetPhD
           {
               FirstName = "Ameliya",
               Surname = "Kurbas",
               Patronymic = "Ivanivna",
               Semester = 1,
               HasScholarship = true,
           },
           new ContractBachelor
           {
               FirstName = "Andriy",
               Surname = "Buhrovuch",
               Patronymic = "Ivanovych",
               Semester = 1,
           },           
       };
    }
}
