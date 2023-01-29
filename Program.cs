using System;

namespace Trening_28_01_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            var sign = "";

            Console.WriteLine("Kalkulator BMI oraz zapotrzebowania kalorycznego: ");

            Wybor ob1 = new Wybor();

            do
            {
                Console.WriteLine("BMI - 1 ; Zapotrzebowanie KCAL - 2");
                ob1.ControlChange();
                Console.WriteLine("Wyjscie t/n");
                sign = Console.ReadLine();

                if (sign != "t" && sign != "n")
                {
                    sign = "t";
                    Console.WriteLine("Nie poprawny znak koniec programu");
                }

            } while (sign != "t" || sign == "n");
        }
    }
}
