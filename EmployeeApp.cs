using System;

class EmployeeApp
{
	public static void Main()
	{
		Employee emp = new Employee("Edilber","Pérez",31,200);
		Console.WriteLine("\nLa paga de Edilber es $" + emp.CalculatePay(40));
		Console.ReadLine();
	}
}