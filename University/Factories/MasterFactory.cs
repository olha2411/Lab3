using System;
using System.Collections.Generic;
using University.Interface;
using University.AbstractLevels;
using University.Students.BudgetStudents;
using University.Students.ContractStudents;

namespace University.Factories
{
    public class MasterFactory : IFactory
    {
        public Budget CreateBudgetStudent()
        {
            return new BudgetMaster();
        }

        public Contract CreateContractStudent()
        {
            return new ContractMaster();
        }
    }
}
