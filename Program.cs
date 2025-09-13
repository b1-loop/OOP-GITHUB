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
        }
    }
}
