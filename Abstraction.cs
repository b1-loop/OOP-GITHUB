namespace OOP_GITHUB
{
    public abstract class DriverLicense //abstrakt klass för att utan objekt skapa mall för olika typer av körkort
    {

    }

    public class BLicense : DriverLicense  //basklass för bilkörkort som ärver från DriverLicense abstrakt klassen
    {
        public void DriveCar()
        {
            Console.WriteLine("You can drive only car with maximum weight of 3500kg."); //den personen har bilkörkort och kan köra bara bil
        }
    }

    public class DLicense : DriverLicense //basklass för busskörkort som ärver från DriverLicense abstrakt klassen
    {
        public void DriveBus()
        {
            Console.WriteLine("You can drive a car but also is qualified for a bus ."); //samma sak som ovan fast för buss istället för bil
        }
    }
}
