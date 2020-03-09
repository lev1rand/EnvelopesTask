using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopesTask.Classes.Objects
{
    abstract class Quadrangle
    {
        #region

        private const int MAX_QUANTITY = 4;

        #endregion

        public double[] sides;

        public double[] angles;
        
        public Quadrangle()
        {
            sides = new double[MAX_QUANTITY];
            angles = new double[MAX_QUANTITY];
            sides.Initialize();
        }
    }
}
