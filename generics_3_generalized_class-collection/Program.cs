using generics_3_generalized_class_collection;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Repository<Person> personRepo = new Repository<Person>();

        personRepo.Add(new Person("Alice"));
        personRepo.Add(new Person("Bob"));

        Console.WriteLine(personRepo.Get(0).Name); 
        Console.WriteLine(personRepo.Get(1).Name); 

        foreach (var person in personRepo.GetAll())
        {
            Console.WriteLine(person.Name);
        }
    }
}


