class Program

{
    static void Main()
    {
        Person myPerson = new Person("Greg", "Heffley", 13, 130);

        Console.WriteLine(myPerson.GetPersonInformation());

        Police myPolice = new Police("Charles", "Lassy", 40, 190, "beater");

        Console.WriteLine(myPolice.GetPoliceInformation());

        Doctor myDoctor = new Doctor("Drake", "Bell", 40, 190, "x-ray");

        Console.WriteLine(myDoctor.GetDoctorInformation());

        List<Person> myPeople = new List<Person>();

        myPeople.Add(myPerson);
        myPeople.Add(myPolice);
        myPeople.Add(myDoctor);

        foreach(Person person in myPeople)
        {
            Console.WriteLine(person.GetPersonInformation());
        }
        
    }


}