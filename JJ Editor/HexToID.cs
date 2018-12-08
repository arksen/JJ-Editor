using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJ_Editor
{
    class HexToID
    {
        public static void hexToID(char[] hexID)
        {
            int one = 0;
            int two = 1;
            int three = 2;
            int four = 3;

            char temp = hexID[one];
            hexID[0] = hexID[3];

            char temp1 = hexID[two];
            hexID[1] = temp;

            char temp2 = hexID[three];
            hexID[2] = temp1;

            hexID[3] = temp2;
        }
    }
}
