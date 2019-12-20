using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Pet
    {
        public int PatId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;

        public Pet(int patId, string name, string color, string gender)
        {
            this.PatId = patId;
            this.Name = name;
            this.Color = color;
            this.Gender = gender;
        }

        public virtual string MakeSound()
        {
            return "";
        }
    }
}
