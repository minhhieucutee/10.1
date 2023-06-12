using System;

class TestProgram
{
    static void Main(string[] args)
    {
        SeniorLecturer lecturer1 = new SeniorLecturer("John Doe", 70000);
        SeniorLecturer lecturer2 = new SeniorLecturer("Jane Smith", 55000);

        try
        {
            lecturer1.CalculateBonus(12000);
        }
        catch (AmountException ex)
        {
            Console.WriteLine("{0} - Error: {1}", ex.PersonName, ex.Message);
        }

        try
        {
            lecturer2.CalculateBonus(8000);
        }
        catch (AmountException ex)
        {
            Console.WriteLine("{0} - Error: {1}", ex.PersonName, ex.Message);
        }

        // Demonstrating polymorphism
        SeniorLecturer lecturer3 = new SeniorLecturer("Alice Brown", 65000);
        Lecturer lecturer4 = new Lecturer("Bob Green", 50000);

        lecturer3.CalculateBonus(6000);
        lecturer4.CalculateBonus(4000);
    }
}

class Lecturer : SeniorLecturer
{
    public Lecturer(string name, double salary) : base(name, salary)
    {
    }

    public new void CalculateBonus(double bonusAmount)
    {
        Console.WriteLine("Bonus calculated: {0}", bonusAmount);
    }
}
