using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenia3.Wyjątki
{
    internal class OverfillException: System.Exception
    {
        public OverfillException() { Console.WriteLine("Masa ladunku przekracza maksymalną pojemnosc kontenera"); }
    }
}
