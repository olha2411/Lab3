using System;
using University.AbstractLevels;

namespace University.Students.BudgetStudents
{
    public class BudgetPhD : Budget
    {   
        public BudgetPhD() : base()
        {
            ScholarshipAmount = 7000;
        }
        public override string ToString()
        {
            return "Budget PhD student";
        }

    }
}
