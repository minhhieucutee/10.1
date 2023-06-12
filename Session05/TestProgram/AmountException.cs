using System;

class AmountException : Exception
{
    private string personName;

    public AmountException(string personName, string message) : base(message)
    {
        this.personName = personName;
    }

    public stringName
    {
        get { return personName; }
    }
}
