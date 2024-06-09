using num_1;
using num_2;
using num_3;
using num_4;

namespace hw_13._05
{
    // Модуль 6 (наследование)
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            
            Console.WriteLine("Номер 1");

            Product product = new Product(50, 25, "apple");
            product.PrintSum();
            Console.Write("\nНа сколько копеек надо уменьшить цену: ");
            int kop = int.Parse(Console.ReadLine());
            product.Lessen(kop);
            product.PrintSum();
            
            // 2
            
            Console.WriteLine("\nНомер 2");

            Kettle kettle = new Kettle("Kettle", "red", "буль?");
            Microwave microwave = new Microwave("Microwave", "blue", "ввуу");
            Car car = new Car("Car", "black", "вррруум");
            Steamboat steamboat = new Steamboat("Steamboat", "green", "steamboat_sound");

            kettle.Show(); kettle.Desc(); kettle.PrintSound();
            microwave.Show(); microwave.Desc(); microwave.PrintSound();
            car.Show(); car.Desc(); car.PrintSound();
            steamboat.Show(); steamboat.Desc(); steamboat.PrintSound();
            
            // 3
            
            Console.WriteLine("\nНомер 3");

            Violin violin = new Violin("Violin", "brown", "viii", "violin_history");
            Trombone trombone = new Trombone("Trombone", "black", "trombone_sound", "trombone_history");
            Ukulele ukulele = new Ukulele("Ukulele", "red", "tru", "ukulele_history");
            Cello cello = new Cello("Cello", "white", "vvvi?", "cello_history");

            violin.Show(); violin.Desc(); violin.PrintSound(); violin.PrintHistory();
            trombone.Show(); trombone.Desc(); trombone.PrintSound(); trombone.PrintHistory();
            ukulele.Show(); ukulele.Desc(); ukulele.PrintSound(); ukulele.PrintHistory();
            cello.Show(); cello.Desc(); cello.PrintSound(); cello.PrintHistory();
            
            // 4
            Console.WriteLine("\nНомер 4\n");

            President president = new President("president", "presidentovich", 100, "President");
            Security security = new Security("security", "securitovich", 95, "Security");
            Manager manager = new Manager("manager", "managerovich", 25, "Manager");
            Engineer engineer = new Engineer("engineer", "engineerovich", 56, "Engineer");

            president.Print();
            security.Print();
            manager.Print();
            engineer.Print();
        }
    }
}