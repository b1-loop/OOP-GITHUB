

namespace OOP_GITHUB
{
    public class Inkapsling
    {
        private int money;  //denna ska vara privat ingen ska se personens pengar

        public Inkapsling(int Money) //konstruktor som tar Money som parameter
        {
            money = Money; //sätter money till Money det vill säga jag kan sätta värde på money när jag skapar objekt av klassen
        }

        public int Money
        {
            get { return money; }  // get metoden returnerar money
            set { money = value; } // set metoden sätter money till value det vill säga jag kan låsa upp den privata variabeln i program cs så länge
            //jag använder set metoden så länge jag skriver ett int värde inom parentesen så kan jag retura värdet och göra den public då
        }

        public void ShowMoney() //min metod ShowMoney som visar hur mycket pengar någon har
        {
            Console.WriteLine($"Hon tjänar {money} kr förre skatt.");
        }
    }   
}
