using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }

    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>
    {
        new Person { Name = "Akash", Age = 18, City = "Vatakara"},
        new Person { Name = "asdfgh", Age = 48, City = "Vatakara"},
        new Person { Name = "fgh", Age = 58, City = "rtyh"},
        new Person { Name = "oulk", Age = 28, City = "Vatakara"},
        new Person { Name = "poiu", Age = 64, City = "qwerty"},
    };

        var result = people
                     .Where(p => p.Age > 25)
                     .Where(p => p.City == "Vatakara")
                     .Select(p => new
                     {
                         p.Name,
                         p.Age

                     });

        foreach (var person in result)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }

    }
}
