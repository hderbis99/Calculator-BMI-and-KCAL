using System;
using System.Collections.Generic;
using System.Text;

namespace Trening_28_01_2023
{
    class BMI : Deficyt
    {
        StringBuilder sb = new StringBuilder();

        public float CalculatorBMI(float BMI)
        {
            sb.Append(Console.ReadLine());
            short Weigth = short.Parse(sb.ToString());

            sb.Clear();

            sb.Append(Console.ReadLine());
            float HowLong = float.Parse(sb.ToString());

            BMI = (Weigth / HowLong);

            return BMI;
        }
    }
}
