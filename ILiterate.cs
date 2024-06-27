using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingMonkeys
{
    internal interface ILiterate
    {
        public (bool isNumber, int userAnswer) Answer();
    }
}
