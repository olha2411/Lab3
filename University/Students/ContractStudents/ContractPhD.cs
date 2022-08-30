using System;
using University.AbstractLevels;

namespace University.Students.ContractStudents
{
    public class ContractPhD: Contract
    {
        public ContractPhD() : base()
        {
            Price = 44900;
        }

        public override string ToString()
        {
            return "Contract PhD student";
        }
    }
}
