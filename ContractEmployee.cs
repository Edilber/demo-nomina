class ContractEmployee : Employee
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