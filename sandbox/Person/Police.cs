class Police : Person
{
    private string _weapons;
    public Police(string firstName, string lastName, int age, double weight, string weapons)
    : base(firstName, lastName, age, weight)
    {
        _weapons = weapons;
    }
    
    public override string GetPersonInformation() // override says it can override the implementation given in Person.cs
    {
        return $"{base.GetPersonInformation()} and has a {_weapons}.";
    }

}