using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    public interface ITempSensor
    {
        public int GetTemp();

        public bool RunSelfTest();
            
    }
}
