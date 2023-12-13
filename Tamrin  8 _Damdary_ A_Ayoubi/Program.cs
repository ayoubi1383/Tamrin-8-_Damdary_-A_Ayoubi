using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Tamrin__8__Damdary__A_Ayoubi
{
     class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            


            Cow c1 = new Cow();
            c1.IsMaile = false;
            c1.Weight = 950;
            c1.BirthDate = new DateTime(2020,10,10);
            c1.StressFactor();
            c1.Life();
            animals.Add(c1);

            Cow c2 = new Cow();
            c2.IsMaile = false;
            c2.Weight = 1000;
            c2.BirthDate = new DateTime(2020,05,23);
            c2.StressFactor();
            c2.Life();
            animals.Add(c2);


            foreach (Animal a in animals)
            {
                CCounter c = new CCounter();
                Console.WriteLine($" ID: C{c.Number} IsMaile: {a.IsMaile} Weight: {a.Weight}" +
                    $" BirthDate: {a.BirthDate} Life: {a.Life()} kill: {a.KillPriority()}" +
                    $" Time to Die:{ a.TimeToDie()}");
            }
            foreach (Animal s in animals)
            {
                Console.WriteLine(" stress factor: {0:p2}", s.StressFactor());
            }



            Console.ReadKey();




        }
    }
}
