using System;

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
	
	public double CalculatePay(int hoursWorked)
	{
		//Calcular paga aquí
		return (payRate * (double)hoursWorked);
	}
	
}