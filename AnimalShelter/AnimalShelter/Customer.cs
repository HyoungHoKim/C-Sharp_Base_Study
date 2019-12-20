using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        private DateTime _Birthday;
        private bool _IsQualified;
        public string Address;
        public string Description;

        private List<Pet> _MyPets = new List<Pet>();
        public List<Pet> MyPets
        {
            get { return _MyPets; }
        }

        public bool Adopt(Pet pet)
        {
            if (_IsQualified == true)
            {
                _MyPets.Add(pet);
                return true;
            }
            else return false;
        }

        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;

            this._IsQualified = Age >= 18;
        }

        public DateTime Birthday
        {
            get { return this._Birthday; }
            set
            {
                this._Birthday = value;
                this._IsQualified = Age >= 18;
            }
        }

        public int Age
        {
            get { return DateTime.Now.Year - this._Birthday.Year; }
        }

        public bool IsQualified
        {
            get
            {
                return this._IsQualified;
            }
        }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
}
