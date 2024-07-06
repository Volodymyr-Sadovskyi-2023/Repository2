using System;
using MyPersonApp.Services;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var personService = new PersonService();
        string command;

        do
        {
            Console.WriteLine("Enter a command (A-add, GP-Get by phone, GN-Get by name, GA-Get all, D-Delete by phone, Q-Exit):");
            command = Console.ReadLine().ToUpper();

            switch (command)
            {
                case "A":
                    Console.Write("Enter full name: ");
                    string fullName = Console.ReadLine();
                    Console.Write("Enter phone number: ");
                    string phoneNumber = Console.ReadLine();
                    personService.AddPerson(fullName, phoneNumber);
                    break;

                case "GP":
                    Console.Write("Enter phone number: ");
                    phoneNumber = Console.ReadLine();
                    var person = personService.GetPersonByPhone(phoneNumber);
                    if (person != null)
                    {
                        Console.WriteLine($"Full Name: {person.FullName}, Phone Number: {person.PhoneNumber}");
                    }
                    break;

                case "GN":
                    Console.Write("Enter full name or part of the name: ");
                    fullName = Console.ReadLine();
                    var names = personService.GetPersonsByName(fullName);
                    if (names.Any())
                    {
                        Console.WriteLine($"Names found: {string.Join(", ", names)}");
                    }
                    break;

                case "GA":
                    var allPersons = personService.GetAllPersons();
                    if (allPersons.Any())
                    {
                        foreach (var p in allPersons)
                        {
                            Console.WriteLine($"Full Name: {p.FullName}, Phone Number: {p.PhoneNumber}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No persons found.");
                    }
                    break;

                case "D":
                    Console.Write("Enter phone number: ");
                    phoneNumber = Console.ReadLine();
                    personService.DeletePersonByPhone(phoneNumber);
                    break;

                case "Q":
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }

        } while (command != "Q");
    }
}