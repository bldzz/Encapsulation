using Encapsulation;
using System;

namespace EncapsulationExample
{
 

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of PersonHandler to manage Person objects.
            PersonHandler handler = new PersonHandler();

            try
            {
                // Example: Creating a Person object using the PersonHandler.
                Person person1 = handler.CreatePerson(25, "John", "Doe", 180.5, 75.0);
                Console.WriteLine($"Person created: {person1.FName} {person1.LName}, Age: {person1.Age}, Height: {person1.Height}, Weight: {person1.Weight}");

                // Example: Setting a person's age using the SetAge method.
                handler.SetAge(person1, 30);
                Console.WriteLine($"Updated Age: {person1.Age}");
            }
            catch (ArgumentException ex)
            {
                // Handling validation exceptions and printing the error message.
                Console.WriteLine($"Error: {ex.Message}");
            }

           
        }
    }
}
