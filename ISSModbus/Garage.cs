using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSModbus
{
    class Garage : DrivableObject
    {
        public void Drive(int i)
        {
            if(GarageModbusAdapter.IsCarOutside(i))
            {
                GarageModbusAdapter.SetGateOpened(i, true);
                GarageModbusAdapter.SetInnerLightsOn(i, true);
                GarageModbusAdapter.SetOuterLightsOn(i, true);
                GarageModbusAdapter.SetGateClosed(i, false);
            }
            else if(GarageModbusAdapter.IsCarInside(i))
            {
                GarageModbusAdapter.SetGateOpened(i, false);
                GarageModbusAdapter.SetOuterLightsOn(i, false);
                GarageModbusAdapter.SetGateClosed(i, true);
            }
        }
    }
}
