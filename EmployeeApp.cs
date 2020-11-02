using System;

namespace Nomina
{
	class EmployeeApp
	{
		public static void Main()
		{
			Employee emp = new Employee("001","Edilber","Pérez",31,200);
			Console.WriteLine("\nLa paga de Edilber es $" + emp.CalculatePay(40));
			Console.ReadLine();
		}
	}
	
	class Employee
	{
		public Employee(string EmployeeId, string firstName, string lastName, int age, double payRate)
		{
			this.EmployeeId = EmployeeId;
			this.firstName = firstName;
			this.lastName = lastName;
			this.age = age;
			this.payRate = payRate;
		}
		
		protected string EmployeeId;
		protected string firstName;
		protected string lastName;
		protected int age;
		protected double payRate;
		
		public virtual double CalculatePay(int hoursWorked)
		{
			//Calcular paga aquí
			return (payRate * (double)hoursWorked);
		}
		
	}
	
	class ContractorEmployee : Employee
	{
		public string FederalTaxId;
		
		public ContractEmployee(string EmployeeId, string firstName, string lastName, int age, double payRate) : base (EmployeeId, firstName, lastName, age, payRate)
		{
			
		}
		
		public override double CalculatePay(int hoursWorked)
		{
			//Calcular el pago para un empleado por contrato
			Console.WriteLine("ContractorEmployee.CalculatePay");
			return 42;
			
		}
	}
	
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