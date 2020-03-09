using System;

namespace EnvelopesTask.Classes.Objects
{
    class Square : Parallelogram //square (similiar sides), rectangle(different sides)
    {
        #region

        private const int DEFAULT_SIDE_LENGTH = 4;

        private const int DEFAULT_ANGLE_VALUE = 90;

        #endregion

        public Square() : base()
        {
            for (int index = 0; index < MAX_QUANTITY; index++)
            {
                sides[index] = DEFAULT_SIDE_LENGTH;
                angles[index] = DEFAULT_ANGLE_VALUE;
            }
        }

        public Square(double firstSide, double secondSide, int firstAngle, int secondAngle) : base(firstSide, secondSide, firstAngle, secondAngle)
        {

        }

        new public double CalculateHeight()
        {
            return sides[0] < sides[1] ? sides[0] : sides[1];
        }

        new public double CalculateDiagonal()
        {
            return Math.Sqrt(sides[0] * sides[0] + sides[1] * sides[1]);
        }
    }
}
