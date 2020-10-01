using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate an object
            Person myPerson = new Person("gigi", "dev", Gender.Female);
            //Person yourPerson = new Person(); nu este ok sa avem de genul fara parametrii
            //myPerson.firstName = "gigi"; //- nu este chiar in regula, ca nu-i ok daca le-am cerut o data in constructor nu-i ok sa le mai modificam
           // myPerson.birthDate = DateTime.Now.AddYears(5); - nu se poate sa schimbam data de nastere pt viitor...ea ramane fixa
           

            //string fullName = myPerson.firstName + "Person"; //-nu avem nevoie

            // myPerson.birthDate = DateTime.Now.AddYears(5);
            var name = myPerson.FirstName;

            myPerson.FirstName = "lalal";
            var modifiedName = myPerson.FirstName;

            var fullName = myPerson.FullName;

            //myPerson.gender = "female"; - nu merge chiar daca se vede si este public, pt ca i-am pus readonly la parametru
            Console.WriteLine(myPerson.Age);
            Console.WriteLine("Hello World!");
        }
    }
}
