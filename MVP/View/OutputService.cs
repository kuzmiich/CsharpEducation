using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP.View;

namespace MVP.View
{
    public class OutputService : IView
    {
        public decimal GetDecimal(string data) => decimal.TryParse(data, out var outData) ? outData : default;

        public char GetChar(string data) => char.TryParse(data, out var outData) ? outData : default;
    }
}
