using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    // The Person class contains private fields with public properties to access them.
    public class Person
    {
        // Private fields
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        // Public property for Age with validation
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0) // Validation to ensure age is greater than 0
                    throw new ArgumentException("Age must be greater than 0.");
                age = value;
            }
        }

        // Public property for First Name with validation
        public string FName
        {
            get { return fName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 10)
                    throw new ArgumentException("First Name must be between 2 and 10 characters.");
                fName = value;
            }
        }

        // Public property for Last Name with validation
        public string LName
        {
            get { return lName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 15)
                    throw new ArgumentException("Last Name must be between 3 and 15 characters.");
                lName = value;
            }
        }

        // Public property for Height
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // Public property for Weight
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
