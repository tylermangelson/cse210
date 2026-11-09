class Doctor : Person
{
    private string _tools;
    public Doctor(string firstName, string lastName, int age, double weight, string weapons)
    : base(firstName, lastName, age, weight)
    {
        _tools = weapons;
    }

    
    public override string GetPersonInformation() // override says it can override the implementation given in Person.cs
    {
        return $"{base.GetPersonInformation()} and has a {_tools}.";
    }

}