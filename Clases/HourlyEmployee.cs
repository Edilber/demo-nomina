using System;

namespace Nomina.Clases
{	
	class HourlyEmployee : Employee
	{
		public HourlyEmployee(string EmployeeId, string firstName, string lastName, int age, double payRate) : base (EmployeeId, firstName, lastName, age, payRate)
		{}
		
		public override double CalculatePay(int hoursWorked)
		{
			Console.WriteLine("HourlyEmployee.CalculatePay");
			return 42; //valor imaginario
		}
	}
}