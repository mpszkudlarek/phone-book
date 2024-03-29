﻿namespace PhoneBook
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello from the other sideeeee");

            Console.WriteLine("1 - add contact ");
            Console.WriteLine("2 - display contact by number");
            Console.WriteLine("3 - display all contacts");
            Console.WriteLine("4 - search contact by phrase");
            Console.WriteLine("5 - Delete contact based on number");
            Console.WriteLine("x - exit phonebook");
            // TODO
            // usuwanie kontaktow bazujac na numerze
            var userInput = Console.ReadLine();
            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert number ( Is has to have 9 digits)");
                        var number = Console.ReadLine();

                        if (number.Length != 9)
                        {
                            Console.WriteLine("Chosen number is either too short or too long, try again");
                            break;
                        }
                        else

                            Console.WriteLine("Insert name (Cannot be shorter than 3 letters)");
                        var fullName = Console.ReadLine();
                        if (fullName.Length >= 3)
                        {
                            var newContact = new Contact(fullName, number);
                            phoneBook.AddContact(newContact);
                        }
                        else
                        {
                            {
                                Console.WriteLine("Chosen name is too short, name has be at least 3 letters");
                                break;
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("Insert number");
                        var numbertoSearch = Console.ReadLine();
                        phoneBook.DisplayContact(numbertoSearch);
                        break;

                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;

                    case "4":

                        Console.WriteLine("Insert search phrase");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;

                    case "5":
                        Console.WriteLine("Insert a number to delete");
                        var numberToDelete = Console.ReadLine();
                        phoneBook.RemoveNumber(numberToDelete);

                        break;

                    case "x":
                        return;

                    default:
                        Console.Write("Invalid operation");
                        break;
                }
                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }
        }
    }
}