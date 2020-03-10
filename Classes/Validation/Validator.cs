﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopesTask.Classes.Validation
{
    class Validator
    {
        #region

        static private Dictionary<int, string> errorMessages;

        private const int MIN_PARAMS_REQUIRED = 3;

        private const int PARAMS_REQUIRED = 4;

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

        public bool IsValid(string[] value)
        {
            if (value.Length < MIN_PARAMS_REQUIRED)//too little params
            {
                LogError(1);

                return false;
            }

            if (value.Length > PARAMS_REQUIRED)//too many params
            {
                LogError(2);

                return false;
            }

            if ( !(Int32.TryParse(value[1], out int firstParam) ||
                Int32.TryParse(value[2], out int secondParam) ||
                Int32.TryParse(value[3], out int thirdParam)) )//incorrect type
            {
                LogError(3);

                return false;
            }

            if (Int32.Parse(value[1]) < 0 || Int32.Parse(value[2]) < 0 || Int32.Parse(value[3]) < 0)//negative numbers
            {
                LogError(5);

                return false;
            }

            if (Int32.Parse(value[1]) + Int32.Parse(value[2]) <= Int32.Parse(value[3])
                || Int32.Parse(value[2]) + Int32.Parse(value[3]) <= Int32.Parse(value[1])
                || Int32.Parse(value[1]) + Int32.Parse(value[3]) <= Int32.Parse(value[3]))//isn`t possible to build triangle
            {
                LogError(4);

                return false;
            }

            return true;
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
