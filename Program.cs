using System;

class Employee
{
    private string name;
    private string designation;
    private int noOfExperience;
    private double basicSalary;
    private double insuranceAmount;

    
    public Employee(string name, string designation, int noOfExperience, double basicSalary, double insuranceAmount)
    {
        this.name = name;
        this.designation = designation;
        this.noOfExperience = noOfExperience;
        this.basicSalary = basicSalary;
        this.insuranceAmount = insuranceAmount;
    }

    
    public double CalculateSalary()
    {
        double hra = 0.2 * basicSalary; // HRA is 20% of basic salary
        double ta = 0.1 * basicSalary; // TA is 10% of basic salary
        double grossSalary = basicSalary + hra + ta + insuranceAmount; // Gross salary is the sum of basic salary, HRA, TA and insurance amount
        return grossSalary;
    }

    // Method to display the employee details with gross salary
    public void Display()
    {
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Designation: " + designation);
        Console.WriteLine("Number of Years of Experience: " + noOfExperience);
        Console.WriteLine("Basic Salary: " + basicSalary);
        Console.WriteLine("Insurance Amount: " + insuranceAmount);
        Console.WriteLine("Gross Salary: " + CalculateSalary());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter employee name: ");
        string name = Console.ReadLine();

        Console.Write("Enter employee designation: ");
        string designation = Console.ReadLine();

        Console.Write("Enter number of years of experience: ");
        int noOfExperience = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter basic salary: ");
        double basicSalary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter insurance amount: ");
        double insuranceAmount = Convert.ToDouble(Console.ReadLine());

        Employee employee = new Employee(name, designation, noOfExperience, basicSalary, insuranceAmount);
        employee.Display();
    }
}