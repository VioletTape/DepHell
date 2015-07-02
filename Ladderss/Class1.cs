using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireChase;

namespace Ladderss
{
    public class Ladder
    {
        public string Get() {
            return new Chassis().GetChassis("Ladder");
        }
    }
}
