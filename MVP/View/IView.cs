using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.View
{
    internal interface IView
    {
        decimal GetDecimal(string data);

        char GetChar(string data);
    }
}
