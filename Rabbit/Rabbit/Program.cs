using Microsoft.VisualBasic;
using System;

namespace Rabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner myOwner = new Owner("Gigi", "Dev", 47, "Ascunzatoare");

            Rabbit myRabbit = new Rabbit(Eyes.Blue, Fur.Brown, Gender.Male, new DateTime(1999,4,4), myOwner);
            
            Console.WriteLine(myRabbit.Eyes);
            Console.WriteLine(myRabbit.Fur);
            Console.WriteLine(myRabbit.Gender);
            Console.WriteLine(myRabbit.Age);
            Console.WriteLine(myRabbit.Owner.First);
            Console.WriteLine(myRabbit.Owner.Last);
            Console.WriteLine(myRabbit.Owner.OwnerCode);
            Console.WriteLine(myRabbit.Owner.OwnerAddress);
           

        }
    }
}
