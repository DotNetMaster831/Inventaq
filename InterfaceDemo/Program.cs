namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Employee employee = new Employee();
            //ImplementationClass1 obj1 = new ImplementationClass1();
            ITestInterface1 obj1 = new ImplementationClass1();
            obj1.Add(10, 20);

            ITestInterface2 obj2 = new ImplementationClass2();
            obj2.Add(10, 20);
            obj2.Sub(10, 20);

            Console.ReadKey();
        }
    }

    public abstract class Employee
    {
        int age = 25;
        string name = "dotne";

        public string Gender { get; set; }

        public Employee()
        {

        }

        public string GetName()
        {
            return "Arjun";
        }
        public abstract void Greet();

        //Vraibles
        //props
        //regular methods
        //abstract methods
        //ctor
    }

    public class Manager : Employee
    {
        public override void Greet()
        {
            throw new NotImplementedException();
        }
    }

    public class HR : Employee
    {
        public override void Greet()
        {
            throw new NotImplementedException();
            {
            }
        }
    }
}
