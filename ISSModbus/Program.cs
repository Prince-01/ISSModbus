using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ISSModbus
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b = new Building(4);
            b.SetWantedTemperatureToRoomN(0, 25);
            b.SetWantedTemperatureToRoomN(1, 14);
            b.SetWantedTemperatureToRoomN(2, 26);
            b.SetWantedTemperatureToRoomN(3, 22);
            b.PrintRooms();
            //comment

            while (true)
            {
                b.Drive();
                b.PrintRooms();
                switch (Console.ReadKey().KeyChar)
                {
                    case 'o':
                    case 'O':
                        GarageModbusAdapter.SetCarOutside(0, !GarageModbusAdapter.IsCarOutside(0));
                        break;
                    case 'i':
                    case 'I':
                        GarageModbusAdapter.SetCarInside(0, !GarageModbusAdapter.IsCarInside(0));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
