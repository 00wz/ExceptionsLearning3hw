using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessom3hw
{
    class IncorrectPersonDataExeption: Exception
    {
        public IncorrectPersonDataExeption(string massage):base(massage)
        {
        }
    }
}
