using System;

class SeniorLecturer
{
    private string name;
    private double salary;

    public SeniorLecturer(string name, double salary)
    {
        this.name = name;
        this.salary = salary;
    }

    public void CalculateBonus(double bonusAmount)
    {
        if (this.salary < 60000)
        {
            throw new AmountException(this.name, "Salary is less than 60,000!");
        }

        if (bonusAmount > 10000)
        {
            throw new AmountException(this.name, "Bonus amount should not be more than 10,000!");
        }

        Console.WriteLine("Bonus calculated: {0}", bonusAmount);
    }
}
