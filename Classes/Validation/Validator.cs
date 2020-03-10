using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvelopesTask.Classes.Objects;

namespace EnvelopesTask.Classes.Validation
{
    class Validator
    {
        #region

        static private Dictionary<int, string> errorMessages;

        private const int MIN_PARAMS_REQUIRED = 3;

        private const int PARAMS_REQUIRED = 4;

        private const int SQUARE_ANGLE = 90;

        #endregion

        public Validator()
        {
            errorMessages = new Dictionary<int, string>();

            AddError(1, "Too little parameters");
            AddError(2, "Too many parameters");
            AddError(3, "Wrong type of the value inputted");
            AddError(4, "Incorrect range of data inputted");
            AddError(5, "Negative numbers inputted");
        }

        public bool IsValid(string[] value, Type objectType)
        {
            if (value.Length > PARAMS_REQUIRED)//too little params
            {
                LogError(1);

                return false;
            }

            if (value.Length < MIN_PARAMS_REQUIRED)//too many params
            {
                LogError(2);

                return false;
            }

            if (value.Length == PARAMS_REQUIRED)//4 params inputted
            {
                if (!(Double.TryParse(value[0], out double firstParam) &&
                    Double.TryParse(value[1], out double secondParam) &&
                    Double.TryParse(value[2], out double thirdParam) &&
                    Double.TryParse(value[3], out double fourthParam))
                    )
                {
                    LogError(3);

                    return false;
                }

                if (Double.Parse(value[0]) < 0 ||
                    Double.Parse(value[1]) < 0 ||
                    Double.Parse(value[2]) < 0 ||
                    Double.Parse(value[3]) < 0)//negative numbers inputted
                {
                    LogError(5);

                    return false;
                }

                if (objectType == typeof(Square))
                {
                    if (!(Int32.TryParse(value[2], out int firstAngle) ||
                        Int32.TryParse(value[3], out int secondAngle) ||
                        firstAngle != SQUARE_ANGLE || secondAngle != SQUARE_ANGLE))//square should have only 90 angles per side
                    {
                        LogError(4);

                        return false;
                    }
                }
                else
                {
                    if(objectType == typeof(Parallelogram))
                    {

                    }
                }
                return true;
            }
        }

        private void LogError(int code)
        {
            Logger.Log.Error(errorMessages[code]);
        }

        public void AddError(int errorCode, string description)
        {
            foreach (var item in errorMessages)
            {
                if (item.Key == errorCode)
                {
                    return;
                }
            }

            errorMessages.Add(errorCode, description);
        }
    }
}
