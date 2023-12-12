using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    // Klass för att hålla data om en person
    public class Person
    {
        public Gender Gender { get; private set; }
        public Hair Hair { get; private set; }
        public DateTime Birthdate { get; private set; }
        public string EyeColor { get; private set; }

       

        public Person (Gender gender, Hair hair, DateTime birthdate, String eyecolor) 
        {
            Gender = gender;
            Hair = hair;
            Birthdate = birthdate;
            EyeColor = eyecolor; 
        }

        //ToString-metod för att returnera lämplig data om personen
        public override string ToString()
        {
            return $"Gender: {Gender}" +
                $"\nHair : {Hair.HairLength} {Hair.HairColor}" +
                $"\nEyecolor : {EyeColor}" +
                $"\nBirthdate : {Birthdate:yyyy/MM/dd}"; 

        }

    }
}
