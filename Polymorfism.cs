
namespace OOP_GITHUB
{
    public class Polymorfism : Person  //skapat en ny klass som heter polymorfism som ärver från person klassen
    {
        public override void IntroduceYourself() //override nyckelordet används för att ändra en metod som ärvs från en basklass
        {
            Console.WriteLine($"Hi, I'm {Name} {Surname}, a {Age}-year-old individual."); //override metoden IntroduceYourself från person klassen och ändrar presentationen
        }

    }
}
