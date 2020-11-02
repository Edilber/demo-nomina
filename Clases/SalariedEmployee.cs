using System;

namespace Nomina.Clases
{
	class SalariedEmployee : Employee
	{
		public string SocialSecurityNumber;
		
		public SalariedEmployee(string EmployeeId, string firsName, string lastName, int age, double payRate) : base (EmployeeId, firsName, lastName, age, payRate)
		{
			
		}
		
		public override double CalculatePay(int hoursWorked)
		{
			//Calcular el pago para el empleado W-2
			Console.WriteLine("SalariedEmployee.CalculatePay");
			return 42;
			
		}
		
	}
}