using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    public interface IHeater
    {
        public void TurnOn();

        public void TurnOff();

        public bool RunSelfTest();


    }
}
