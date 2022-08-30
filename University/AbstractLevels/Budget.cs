using System;


namespace University.AbstractLevels
{
    public abstract class Budget : Student
    {       
        public decimal ScholarshipAmount { get; protected set; }
        public bool HasScholarship { get; set; }

        public void GetScholarship() 
        {
            if (HasScholarship)
            {
                Score += ScholarshipAmount;
            }            
        }
    }

    
}
