using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWithExceptions
{
    public class Dog
    {
        //fields
        private string _name;
        private sbyte _age;

        //properties
        public string Name
        {
            get { return _name; }
            set 
            {
                if (value.Length < 2)
                {
                    throw new System.ApplicationException("Length of characters for name is too short. Must beat least 2 characters.");
                }
                _name = value;
            }
        }

        public sbyte Age
        {
            get { return _age; }
            set 
            {
                if (value > 100)
                {
                    throw new System.ApplicationException("Age of dog is too big. Must be between 0 and max 100 years.");
                }

                if (value < 0)
                {
                    throw new ArgumentException("Age of dog cannot be a negative number.");
                }
                _age = value; 
            }
        }

        //Constructor
        public Dog()
        {
            this._name = "test";
            this._age = 0;
        }
    }
}
