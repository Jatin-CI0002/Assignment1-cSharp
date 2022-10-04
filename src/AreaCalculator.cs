using System;

namespace Assignments
{
    public class AreaCalculator
    {
        public static double CalculateRequiredArea(int input)
        {
            double radius = 0;
            if (input != 0)
                radius = Convert.ToDouble(input);

            else
                return 0;

            double rSquare = radius * radius;
            double triangle = rSquare;  
            double rightWridge = rSquare - ((0.25 * Math.PI * rSquare));
            double sectorArea = ((rSquare * (Math.PI - 2 * Math.Atan(0.5)) / 2) - (rSquare * 0.4));

            return Math.Round(triangle - (rightWridge + sectorArea),3);
        }
    }
}
