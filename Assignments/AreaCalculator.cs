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

            double triangle = (radius * radius);
            double rightWridge = (radius *radius) - ((0.25 * Math.PI * (radius * radius)));
            double sectorArea = (8 * Math.PI) - (16 * Math.Atan(0.5)) - 6.4;

            
            return Math.Round(triangle - (rightWridge + sectorArea),3);
        }
    }
}
