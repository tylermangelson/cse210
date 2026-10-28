class Program
{
    static void Main()
    {
        Person myPerson = new Person("Greg", "Heffley", 13, 130);

        myPerson.DisplayPersonInformation();

        Police myPolice = new Police("Charles", "Lassy", 40, 190, "knife");

        myPolice.DisplayPersonInformation();
    }


}