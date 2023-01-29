using System;
using System.Collections.Generic;
using System.Text;

namespace Trening_28_01_2023
{
    class Wybor : BMI 
    {
        sbyte control;
        float BMI = 0;

        double KCALG, KCALM;


        public void ControlChange()
        {
            StringBuilder sb = new StringBuilder();

            sb.Clear();

            sb.Append(Console.ReadLine());
            control = sbyte.Parse(sb.ToString());

            security(control);

            switch(control)
            {
                case 1:
                    Console.WriteLine("BMI: ");
                    Console.WriteLine("Wpisz swoją wagę [Kg] oraz [m]: ");

                    BMI ob1 = new BMI();
                    Console.WriteLine("Twoje BMI: " + ob1.CalculatorBMI(BMI));

                    break;
                case 2:
                    Console.WriteLine("Zapotrzebowanie KCAL: ");

                    BMI ob2 = new BMI();
                    Console.WriteLine("Dzienne zapotrzebowanie kaloryczne: " + ob2.CalculatorDefi(KCALG, KCALM) + " KCAL");

                    break;
            }
        }
        private sbyte security(sbyte a)
        {
            if(a != 1 && a != 2)
            {
                Console.WriteLine("Wpisałeś zły znak: ");
            }
            return 0;
        }
    }
}
