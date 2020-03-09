using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopesTask.Classes.Objects
{
    class Square : Parallelogram
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

        public Square(double firstSide, double secondSide, int firstAngle, int secondAngle):base(firstSide, secondSide, firstAngle, secondAngle)
        {

        }

    }
}
