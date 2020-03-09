using System;
using EnvelopesTask.Interfaces;

namespace EnvelopesTask.Classes.Objects
{
    class Parallelogram : IHeightCalculable, IDiagonalCalculable//parallelogram(different sides), rhombus (similiar sides)
    {
        #region

        protected const int MAX_QUANTITY = 4;

        protected double Height() => CalculateHeight();

        protected double Diagonal() => CalculateDiagonal();

        #endregion

        public double[] sides;

        protected double[] angles;

        public Parallelogram()
        {
            sides = new double[MAX_QUANTITY];
            angles = new double[MAX_QUANTITY];

            sides.Initialize();
            angles.Initialize();
        }

        public Parallelogram(double firstSide, double secondSide, int firstAngle, int secondAngle)
        {
            sides = new double[MAX_QUANTITY];
            angles = new double[MAX_QUANTITY];

            if (firstAngle > secondAngle)
            {
                var temp = firstAngle;
                firstAngle = secondAngle;
                secondAngle = temp;
            }
            for (int index = 0; index < MAX_QUANTITY; index++)
            {
                if (index % 2 == 0)
                {
                    sides[index] = firstSide;
                    angles[index] = firstAngle;
                }
                else
                {
                    sides[index] = secondSide;
                    angles[index] = secondAngle;
                }
            }
        }

        public double CalculateHeight()
        {
            return sides[0] * Math.Sin(angles[0]* 0.0175);
        }

        public double CalculateDiagonal()
        {
            return Math.Sqrt(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - 2 * sides[0] * sides[1] * Math.Cos(angles[0] * 0.0175));
        }
    }
}
