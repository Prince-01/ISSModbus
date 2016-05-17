using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSModbus
{
    class Room : DrivableObject
    {
        public void Drive(int i)
        {
            if (Modbus.GetIntegerOutput(i) < Modbus.GetIntegerInput(2 * i))
                Modbus.SetIntegerOutput(i, Modbus.GetIntegerOutput(i) + 0.5);
            else
                Modbus.SetIntegerOutput(i, Modbus.GetIntegerOutput(i) - 0.5);
        }
    }
}
