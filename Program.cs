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
            person2.IntroduceYourselfWithJob(); //anropar metoden IntroduceYourselfWithJob som jag hade i arv klassen och nu utöver person mallen 
            //så får Melissa även en job titel

            Inkapsling person3 = new Inkapsling(35000);
            person3.ShowMoney(); //anropar metoden ShowMoney som visar hur mycket pengar personen har

            Polymorfism person4 = new Polymorfism(); //skapat ett objekt av polymorfism klassen som ärver från person klassen
            person4.Name = "Emilya";                 //sätter värde på namn, efternamn och alder på nytt 
            person4.Surname = "Ivanova";
            person4.Age = 56;
            person4.IntroduceYourself(); //anropar metoden IntroduceYourself som är override i polymorfism klassen

        }
    }
}
