namespace OpenClose
{
    public abstract class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public abstract decimal CalculateSalaryMonthly();
    }
}


/*
namespace OpenClose
{  
	public interface IEmployee
  	{
    		public string Fullname { get; set; }
		public int HoursWorked { get; set; }
    		public decimal CalculateSalaryMonthly();
  	}
}

*/