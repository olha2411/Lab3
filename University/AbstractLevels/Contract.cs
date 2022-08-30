using System;

namespace University.AbstractLevels
{
    public abstract class Contract : Student    
    {
        private DateTime _date;
        public decimal Price { get; protected set; }

        public bool Pay() 
        {
            if (Score >= Price)
            {
                Score -= Price;
                _date = DateTime.Today;
                return true;
            }
            
            return false;                
        }

        public void ReplenishAccount(decimal sum)
        {
            Score += sum;
        }

        public bool CheckPayment() 
        {
            return (DateTime.Today - _date).Days < 150;           
        }
        
    }
}
