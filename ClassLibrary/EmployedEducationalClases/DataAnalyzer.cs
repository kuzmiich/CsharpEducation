using System;

namespace ClassLibrary.EmployedEducationalClases
{
    class DataAnalyzer
    {
        public DataAnalyzer()
        {
        }

        public DataAnalyzer(string data, string operationName)
        {
            _data = data;
            OperationName = operationName;
        }

        public long Count { get { return _data.Length; } }
        public string OperationName { get; }
        private readonly string _data;

        public float[] ConvertToFloatNumber(string data, char separator)
        {
            var arrString = data.Split(separator);
            float[] arrNumbers = { };
            for (int i = 0; i < arrString.Length; i++)
            {
                if (IsFloatNumber(arrString[i]))
                {
                    arrNumbers[i] = Convert.ToSingle(arrString[i]);
                }
            }
            return arrNumbers;
        }
        public bool IsFloatNumber(string data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (!isValid(data[i]))
                {
                    return false;
                }
            }
            return true;
        }
        private bool isValid(char c)
        {
            return c > '0' && c < '9' || c == ',' || c == '.';
        }
    }
}
