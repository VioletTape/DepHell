using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireChase
{
    public class Chassis
    {
        public string GetChassis(string equip, int length = 20) {
            return "Fire chassis v1.0.1 and " + equip + " length " + length.ToString();
        }
    }
}
