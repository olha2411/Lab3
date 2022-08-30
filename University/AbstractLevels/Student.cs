using System;
using System.Collections.Generic;
using System.Text;

namespace University.AbstractLevels
{
    public abstract class Student
    {
        public string FirstName { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;

        public string Patronymic { get; set; } = string.Empty;

        public string FullName => $"{Surname} {FirstName} {Patronymic}".TrimEnd();

        public ushort Semester { get; set; }

        public decimal Score { get; protected set; }
       
    }
}
