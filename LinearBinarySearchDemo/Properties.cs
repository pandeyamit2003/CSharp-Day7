using System;

class Person
{
    private string name;
    private int age;

    // Property for Name
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    // Property for Age (with validation)
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age cannot be negative.");
            }
            age = value;
        }
    }
}

class Properties
{
    static void Main()
    {
        Person person = new Person();

        // Setting values using properties
        person.Name = "Amit";
        person.Age = 23;

        // Getting values using properties
        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);
    }
}