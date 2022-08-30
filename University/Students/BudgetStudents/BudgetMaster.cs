using System;
using University.AbstractLevels;

namespace University.Students.BudgetStudents
{
    public class BudgetMaster : Budget
    {
        public BudgetMaster() : base()
        {
            ScholarshipAmount = 2000;
        }
        public override string ToString()
        {
            return "Budget Master student";
        }
    }
}
