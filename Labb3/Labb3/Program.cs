
namespace Labb3
{
    internal class Program
    {
        static void Main(string[] args)
        //Skapa ett personobjekt och hårdkoda värden för egenskaperna
        {
            Gender gender = Gender.Man;
            Hair hair = new Hair { HairLength = "Medium", HairColor = "Blond" };
            DateTime birthdate = new DateTime(1999, 06, 06);
            string eyecolor = "Green";

            Person person = new Person(gender, hair, birthdate, eyecolor);

            // Skriv ut data om personen till konsolen
            Console.WriteLine(person.ToString());
        }

    }
}
