using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJ_Editor
{
    class IDToHex
    {
        public static string idToHex(int itemID)
        {
            // Convert Item ID to Hex thanks to Winter Snake
            var hexData = new StringBuilder(itemID.ToString("X4"));
            var temp = new char[2];

            temp[0] = hexData[0];
            temp[1] = hexData[1];
            hexData[0] = hexData[2];
            hexData[1] = hexData[3];
            hexData[2] = temp[0];
            hexData[3] = temp[1];

            return hexData.ToString();

        }
    }
}
