using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.src.Application.Mobility
{
    interface VehicleMobility
    {
        void SpeedUp();
        void Stop();
        void SlowDown();
        void TurnOn();
        void TurnOff();
    }
}
