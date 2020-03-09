using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopesTask.Classes.Objects
{
    class Parallelogram
    {
        #region

        protected const int MAX_QUANTITY = 4;

        #endregion

        public double[] sides;

        public int[] angles;
        
        public Parallelogram()
        {
            sides = new double[MAX_QUANTITY];
            angles = new int[MAX_QUANTITY];
            sides.Initialize();
            angles.Initialize();
        }

        public Parallelogram(double firstSide, double secondSide, int firstAngle, int secondAngle)
        {
            sides = new double[MAX_QUANTITY];
            angles = new int[MAX_QUANTITY];

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
    }
}
