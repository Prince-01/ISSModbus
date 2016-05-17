using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSModbus
{
    class BuildingGarageDriver : Driver
    {
        List<DrivableObject> drivables = new List<DrivableObject>();

        public void AddObjectToDrive(DrivableObject drivable)
        {
            GarageModbusAdapter.SetCarOutside(drivables.Count, false);
            GarageModbusAdapter.SetCarInside(drivables.Count, false);

            GarageModbusAdapter.SetGateOpened(drivables.Count, false);
            GarageModbusAdapter.SetGateClosed(drivables.Count, true);
            GarageModbusAdapter.SetOuterLightsOn(drivables.Count, false);
            GarageModbusAdapter.SetInnerLightsOn(drivables.Count, false);

            drivables.Add(drivable);
        }

        public void Drive()
        {
            for (int i = 0; i < drivables.Count; i++)
            {
                DrivableObject garage = drivables[i];

                garage.Drive(i);
            }
        }
    }
}
