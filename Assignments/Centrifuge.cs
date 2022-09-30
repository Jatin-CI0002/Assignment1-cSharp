using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Centrifuge
    {
         public static bool BalanceTheConfiguration(int total, int filled)
            {
                int remainingHole = total - filled;
                if ((filled == total) || (filled >= remainingHole && remainingHole != 1 && filled % remainingHole == 0) || (remainingHole > filled && filled != 1 && remainingHole % filled == 0))
                    return true;
                return false;
            }
        
    }
}
