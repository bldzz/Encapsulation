using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    // This class is responsible for managing Person objects.
    public class PersonHandler
    {
        // This method sets the Age of a person using encapsulated logic.
        public void SetAge(Person pers, int age)
        {
            pers.Age = age; // Calls the Age property to set age with validation
        }

        // This method creates a new Person object and assigns values to all fields.
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            // Using the Person class properties to assign values with validation.
            Person newPerson = new Person
            {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight
            };
            return newPerson;
        }


    }
}
