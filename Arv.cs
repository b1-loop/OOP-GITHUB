

namespace OOP_GITHUB
{

    //skapat en arv klass som ärver från person klassen som är även i en brach som heter arv 
    public class Arv : Person
    {
        public string JobTitle;
        public void IntroduceYourselfWithJob()
        {
            Console.WriteLine($"Hello, my name is {Name} {Surname}, I am {Age} years old and I work as a {JobTitle}.");
        }
    }
}
