using System;
using University.AbstractLevels;

namespace University.Students.ContractStudents
{
    public class ContractMaster: Contract
    {
        public ContractMaster() : base()
        {
            Price = 45000;
        }
        
        public override string ToString()
        {
            return "Contract Master student";
        }
    }
}
