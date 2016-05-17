using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSModbus
{
    class BuildingTemperatureDriver : Driver
    {
        List<DrivableObject> drivables = new List<DrivableObject>();
        public void AddObjectToDrive(DrivableObject drivable)
        {
            Modbus.SetIntegerInput(2 * drivables.Count, 0);
            Modbus.SetIntegerInput(2 * drivables.Count + 1, 20);
            Modbus.SetIntegerOutput(drivables.Count, 0);

            drivables.Add(drivable);
        }

        public void Drive()
        {
            for (int i = 0; i < drivables.Count; i++)
            {
                DrivableObject drivable = drivables[i];

                if (Modbus.GetIntegerOutput(i) < Modbus.GetIntegerInput(2 * i + 1))
                    Modbus.SetIntegerInput(2 * i, Modbus.GetIntegerInput(2 * i + 1) + 10);
                else
                    Modbus.SetIntegerInput(2 * i, Modbus.GetIntegerInput(2 * i + 1) - 10);

                drivable.Drive(i);
            }
        }
    }
}
