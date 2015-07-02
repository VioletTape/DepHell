using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireChase;

namespace WaterTank
{
    public class WaterTank
    {
         public string Get() {
            return new Chassis().GetChassis("WaterTank");
        }
    }
}
