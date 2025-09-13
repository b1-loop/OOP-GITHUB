namespace OOP_GITHUB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ger mig värde och sedan anropar jag metoden IntroduceYourself som jag hade i person klassen
            Person person1 = new Person();
            person1.Name = "Bozhidar";
            person1.Surname = "Ivanov";
            person1.Age = 27;
            person1.IntroduceYourself();


            //skapat ett objekt av arv klassen som ärver från person klassen och lägger till jobtitle jag la en person till och gav de jobb titel
            Arv person2 = new Arv();
            person2.Name = "Melissa";
            person2.Surname = "Jakob";
            person2.Age = 25;
            person2.JobTitle = "teacher";
            person2.IntroduceYourselfWithJob();
        }
    }
}
