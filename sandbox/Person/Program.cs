class Program

{

    static void DisplayPersonInformation(Person person)
    {
        // if (person is Doctor d)
        //     Console.WriteLine(d.GetDoctorInformation());
        // else if(person is Police p)
        //     Console.WriteLine(p.GetPoliceInformation());
        // else
            Console.WriteLine(person.GetPersonInformation());

    }
    static void Main()
    {
        Person myPerson = new Person("Greg", "Heffley", 13, 130);

        // Console.WriteLine(myPerson.GetPersonInformation());

        Police myPolice = new Police("Charles", "Lassy", 40, 190, "beater");

        // Console.WriteLine(myPolice.GetPoliceInformation());

        Doctor myDoctor = new Doctor("Drake", "Bell", 40, 190, "x-ray");

        // Console.WriteLine(myDoctor.GetDoctorInformation());

        List<Person> myPeople = new List<Person>();

        myPeople.Add(myPerson);
        myPeople.Add(myPolice);
        myPeople.Add(myDoctor);

        foreach(Person person in myPeople)
        {

            DisplayPersonInformation(person);
            // Console.WriteLine(person.GetPersonInformation());
            // if(person is Doctor d)
            // {
            //     Console.WriteLine(d.GetDoctorInformation());
            // }
        }
        
    }


}