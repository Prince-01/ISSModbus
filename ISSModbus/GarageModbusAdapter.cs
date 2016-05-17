using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSModbus
{
    public static class GarageModbusAdapter
    {
        public static bool IsGateOpened(int id)
        {
            return Modbus.GetBooleanOutput(4 * id);
        }
        public static bool IsGateClosed(int id)
        {
            return Modbus.GetBooleanOutput(4 * id + 1);
        }
        public static bool AreOuterLightsOn(int id)
        {
            return Modbus.GetBooleanOutput(4 * id + 2);
        }
        public static bool AreInnerLightsOn(int id)
        {
            return Modbus.GetBooleanOutput(4 * id + 3);
        }
        public static bool IsCarOutside(int id)
        {
            return Modbus.GetBooleanInput(id * 2);
        }
        public static bool IsCarInside(int id)
        {
            return Modbus.GetBooleanInput(id * 2 + 1);
        }

        public static void SetGateOpened(int id, bool val)
        {
            Modbus.SetBooleanOutput(4 * id, val);
        }
        public static void SetGateClosed(int id, bool val)
        {
            Modbus.SetBooleanOutput(4 * id + 1, val);
        }
        public static void SetOuterLightsOn(int id, bool val)
        {
            Modbus.SetBooleanOutput(4 * id + 2, val);
        }
        public static void SetInnerLightsOn(int id, bool val)
        {
            Modbus.SetBooleanOutput(4 * id + 3, val);
        }
        public static void SetCarOutside(int id, bool val)
        {
            Modbus.SetBooleanInput(id * 2, val);
        }
        public static void SetCarInside(int id, bool val)
        {
            Modbus.SetBooleanInput(id * 2 + 1, val);
        }
    }
}
