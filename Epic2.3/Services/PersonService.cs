using MyPersonApp.Models;
using MyPersonApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPersonApp.Services
{
    public class PersonService
    {
        public void AddPerson(string fullName, string phoneNumber)
        {
            if (PersonData.Persons.Any(p => p.PhoneNumber == phoneNumber))
            {
                Console.WriteLine("Error: Phone number already exists.");
                return;
            }
            PersonData.Persons.Add(new Person { FullName = fullName, PhoneNumber = phoneNumber });
            Console.WriteLine("Person added successfully.");
        }

        public Person GetPersonByPhone(string phoneNumber)
        {
            var person = PersonData.Persons.FirstOrDefault(p => p.PhoneNumber == phoneNumber);
            if (person == null)
            {
                Console.WriteLine("Error: No person found with the specified phone number.");
                return null;
            }
            return person;
        }

        public List<string> GetPersonsByName(string fullName)
        {
            var persons = PersonData.Persons.Where(p => p.FullName.Contains(fullName, StringComparison.OrdinalIgnoreCase)).ToList();
            if (persons.Count == 0)
            {
                Console.WriteLine("Error: No persons found with the specified name.");
                return new List<string>();
            }
            return persons.Select(p => p.FullName).ToList();
        }

        public List<Person> GetAllPersons()
        {
            return PersonData.Persons.OrderBy(p => p.FullName).ToList();
        }

        public void DeletePersonByPhone(string phoneNumber)
        {
            var person = PersonData.Persons.FirstOrDefault(p => p.PhoneNumber == phoneNumber);
            if (person == null)
            {
                Console.WriteLine("Error: No person found with the specified phone number.");
                return;
            }
            PersonData.Persons.Remove(person);
            Console.WriteLine("Person deleted successfully.");
        }
    }
}