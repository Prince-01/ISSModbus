using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSModbus
{
    public static class Modbus
    {
        static List<double> int_inputs = new List<double>();
        static List<double> int_outputs = new List<double>();
        static List<bool> bool_inputs = new List<bool>();
        static List<bool> bool_outputs = new List<bool>();

        public static void SetIntegerInput(int id, double val)
        {
            if (int_inputs.Count <= id)
                int_inputs.Add(val);
            else
                int_inputs[id] = val;
        }
        public static double GetIntegerInput(int id)
        {
            return int_inputs[id];
        }

        public static void SetBooleanInput(int id, bool val)
        {
            if (bool_inputs.Count <= id)
                bool_inputs.Add(val);
            else
                bool_inputs[id] = val;
        }
        public static bool GetBooleanInput(int id)
        {
            return bool_inputs[id];
        }


        public static void SetIntegerOutput(int id, double val)
        {
            if (int_outputs.Count <= id)
                int_outputs.Add(val);
            else
                int_outputs[id] = val;
        }
        public static double GetIntegerOutput(int id)
        {
            return int_outputs[id];
        }

        public static void SetBooleanOutput(int id, bool val)
        {
            if (bool_outputs.Count <= id)
                bool_outputs.Add(val);
            else
                bool_outputs[id] = val;
        }
        public static bool GetBooleanOutput(int id)
        {
            return bool_outputs[id];
        }
    }
}
