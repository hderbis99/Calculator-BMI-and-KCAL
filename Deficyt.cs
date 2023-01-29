using System;
using System.Collections.Generic;
using System.Text;


namespace Trening_28_01_2023
{
    class Deficyt
    {
        StringBuilder sb = new StringBuilder();

        byte WeigthG, WeigthM, AgeG, AgeM;
        float HowLongG, HowLongM;
        public double CalculatorDefi(double DefG, double DefM)
        {
            Console.WriteLine("Kobieta - 1 || Mezczyzna - 2");

            sb.Clear();
            sb.Append(Console.ReadLine());
            sbyte control = sbyte.Parse(sb.ToString());

            security(control);

            if(control == 1)
            {
                Console.WriteLine("Podaj masę ciała [kg], Wzrost np. 180 [cm] oraz wiek: ");

                sb.Clear();
                sb.Append(Console.ReadLine());
                WeigthG = byte.Parse(sb.ToString());

                sb.Clear();
                sb.Append(Console.ReadLine());
                HowLongG = float.Parse(sb.ToString());

                sb.Clear();
                sb.Append(Console.ReadLine());
                AgeG = byte.Parse(sb.ToString());

                DefG = 655.1 + (9.563 * WeigthG) + (1.85 * HowLongG) - (4.676 * AgeG);
                return DefG;
            }

            if(control == 2)
            {
                Console.WriteLine("Podaj masę ciała [kg], Wzrost np. 180 [cm] oraz wiek: ");

                sb.Clear();
                sb.Append(Console.ReadLine());
                WeigthM = byte.Parse(sb.ToString());

                sb.Clear();
                sb.Append(Console.ReadLine());
                HowLongM = float.Parse(sb.ToString());

                sb.Clear();
                sb.Append(Console.ReadLine());
                AgeM = byte.Parse(sb.ToString());

                DefM = 66.5 + (13.75 * WeigthM) + (5.003 * HowLongM) - (6.775 * AgeM);
                return DefM;
            }
            return 0;
        }
        private sbyte security(sbyte a)
        {
            if (a != 1 && a != 2)
            {
                Console.WriteLine("Wpisałeś zły znak: ");
            }
            return 0;
        }
    }
}
