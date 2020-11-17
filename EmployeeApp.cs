using System;

namespace Nomina
{
	class EmployeeApp
	{
		public static void Main()
		{
			string nombres;
			string apellidos;
			int edad;
			double sueldo;
			
			Console.WriteLine("****Nomina 2020****");
			Console.WriteLine("\nIngresa el nombre del Empleado");	
			nombres = Console.ReadLine();
			Console.WriteLine("\nIngresa sus apellidos");
			apellidos = Console.ReadLine();
			Console.WriteLine("\nIntroduce su edad");
			edad = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nIntroduce su sueldo diario");
			sueldo = Convert.ToDouble(Console.ReadLine());
			Employee emp = new Employee("1",nombres,apellidos,edad,sueldo);
			Console.WriteLine("\nEl sueldo de {0} es ${1}", nombres +" "+apellidos, emp.CalculatePay(8));
			Console.ReadLine();
		}
	}
	
	class Employee
	{
		public Employee(){}
		
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
		
		public ContractorEmployee(string EmployeeId, string firstName, string lastName, int age, double payRate) : base (EmployeeId, firstName, lastName, age, payRate)
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