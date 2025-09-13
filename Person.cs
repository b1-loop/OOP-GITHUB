using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GITHUB
{

    //skapat person klass jag har namn, efternamn, alder och en metod som presenterar mig sjalv
    // med hjälp av Console.WriteLine visar jag hur jag vill att presentationen ska se ut
    public class Person
    {
        public string Name;
        public string Surname;
        public int Age;
    
        public virtual void IntroduceYourself()
        {
            Console.WriteLine($"Hello, my name is {Name} {Surname} and I am {Age} years old.");
        }

    }    
}
