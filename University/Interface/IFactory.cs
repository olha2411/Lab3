using System;
using University.AbstractLevels;

namespace University.Interface
{
    public interface IFactory
    {      
        Budget CreateBudgetStudent();

        Contract CreateContractStudent();
    }
}
