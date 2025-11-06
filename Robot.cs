
namespace HRConsoleApp
{
    
    public class Robot
    { 
        //Struktur på en klass
        //1. Privata fält
        //2. Publika properties
        //3. Konstruktor
        //4. Methoder.


        //Privata fält

        private string _name;
        private int _age;

        //Publika properties
        //Lite extra funktionalitet här, där om vi sätter ett värde under 0 så sätts det automatiskt till 0.
        //Snippet propfull skapar en property med ett bakomliggnade fält
        public int Age 
        { 
            get {return _age; }

            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                else
                {
                    _age = value;
                }
            }
        }
        //Statisk innebär att den är en del av klassen snarare än klassinstanser, kommer ha samma värde.
        //Kallas på med Robot.Count (klassen) snarare än r.Count (instans). 
        public static int Count { get; set; }

        //Autoproperty, om man inte behöver ha validering eller liknande i koden.
        //Snippet prop.
        //Inget set i detta fallet innebär att det inte går att sätta värdet utanför konstruktorn.
        //Hade vi haft en private set hade det gått att sätta i klassen men inte utanför.
        public int Salary { get; }

        public void SetSalary(int salary)
        {
           // Salary = salary;
        }

        //Konstruktor
        //Snippet ctor
        //Fyller alla nya instanser med datan som anges. 
        public Robot(string name, int age, int salary)
        {
            _name = name;
            Age = age;
            Salary = salary;
            Count++;
        }

        //Metoder
        //För att hämta och sätta värden av privata fält i detta fallet. 
        public string GetName()
        {
            return _name;
        }

        public void setName(string name)
        {
            _name = name;
        }
    }
}