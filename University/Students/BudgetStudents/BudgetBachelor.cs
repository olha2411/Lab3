using System;
using University.AbstractLevels;

namespace University.Students.BudgetStudents
{
    public class BudgetBachelor : Budget
    {       
        public BudgetBachelor() : base()
        {
            ScholarshipAmount = 1930;
        }
        public override string ToString()
        {
            return "Budget Bachelor student";
        }


    }
}
