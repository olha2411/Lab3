using System;
using System.Collections.Generic;
using University.Interface;
using University.AbstractLevels;
using University.Students.BudgetStudents;
using University.Students.ContractStudents;

namespace University.Factories
{
    public class PhDFactory : IFactory
    {
        public Budget CreateBudgetStudent()
        {
            return new BudgetPhD();
        }

        public Contract CreateContractStudent()
        {
            return new ContractPhD();
        }
    }
}
