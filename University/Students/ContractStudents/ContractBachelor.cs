using System;
using University.AbstractLevels;

namespace University.Students.ContractStudents
{
    public class ContractBachelor: Contract
    {        
        public ContractBachelor(): base()
        {
            Price = 42000;
        }
       
        public override string ToString()
        {
            return "Contract Bachelor student";
        }

    }
}
