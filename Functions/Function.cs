using System;

namespace Functions
{
    public class Function
    {

        public static double FunctionOne(double x, double y) //Manyminima_5
        {
            double valx = 0.1 * Math.Pow(x, 2) + 2 * Math.Sin(x) + 1 * Math.Sin(4 * x) + 0.5 * Math.Sin(9 * x) + 0.2 * Math.Sin(48 * x) + 0.07 * Math.Sin(70 * x) + +0.03 * Math.Sin(543 * x);
            double valy = 0.1 * Math.Pow(y, 2) + 2 * Math.Sin(y) + 1 * Math.Sin(4 * y) + 0.5 * Math.Sin(9 * y) + 0.2 * Math.Sin(48 * y) + 0.07 * Math.Sin(70 * y) + +0.03 * Math.Sin(543 * y);

            double valuet = valx + valy;

            double c1 = (1 + Math.Pow(x - 1.21, 4)) / 10000000 + Math.Pow(y + 5.312, 7) / 10000000 - 1 / Math.Pow(x - 1.21, 2) - 1 / (1 + Math.Pow(y + 5.812, 2));
            double c2 = -1 / (1 + Math.Sqrt(5 * Math.Pow(x + 2, 2) + 6 * Math.Pow(y + 3.2, 2)));
            double c3 = -1 / (1 + Math.Sqrt(5 * Math.Pow(x + 5.42, 2) + 6 * Math.Pow(y + 3.2, 2)));
            double c4 = -1 / (1 + Math.Sqrt(5 * Math.Pow(x + 3, 2) + 6 * Math.Pow(y + 3.8, 2)));

            double value = 0.05 * valuet + c1 + c2 + 1.2 * c3 + 0.4 * c4;


            return value;
        }

    }
}
