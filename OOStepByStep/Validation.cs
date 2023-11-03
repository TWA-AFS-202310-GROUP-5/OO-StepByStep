using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public static class Validation
    {
        public static bool IsValidClassNumber(int classNumber)
        {
            return classNumber > 0;
        }
    }
}
