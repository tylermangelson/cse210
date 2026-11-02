class Doctor : Person
{
    private string _tools;
    public Doctor(string firstName, string lastName, int age, double weight, string weapons)
    : base(firstName, lastName, age, weight)
    {
        _tools = weapons;
    }
    public string GetDoctorInformation()
    {
        return $"{_tools}, {GetPersonInformation()}";
    }

}