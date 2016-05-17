using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSModbus
{
    class Building
    {
        Driver temperatureDriver = new BuildingTemperatureDriver();
        Driver garageDriver = new BuildingGarageDriver();

        List<Room> rooms = new List<Room>();
        Garage garage;

        public Building(int rooms)
        {
            for (int i = 0; i < rooms; i++)
            {
                Room newRoom = new Room();
                this.rooms.Add(newRoom);
                this.temperatureDriver.AddObjectToDrive(newRoom);
            }
            garage = new Garage();
            this.garageDriver.AddObjectToDrive(garage);
        }
        public void SetWantedTemperatureToRoomN(int n, double t)
        {
            Modbus.SetIntegerInput(2 * n + 1, t);
        }
        public double GetTemperatureForRoomN(int n)
        {
            return Modbus.GetIntegerOutput(n);
        }
        public bool GetOuterLightsOnForGarageN(int n)
        {
            return GarageModbusAdapter.AreOuterLightsOn(n);
        }
        public bool GetInnerLightsOnForGarageN(int n)
        {
            return GarageModbusAdapter.AreInnerLightsOn(n);
        }
        public bool GetGateClosedForGarageN(int n)
        {
            return GarageModbusAdapter.IsGateClosed(n);
        }
        public bool GetGateOpenedForGarageN(int n)
        {
            return GarageModbusAdapter.IsGateOpened(n);
        }

        public void Drive()
        {
            temperatureDriver.Drive();
            garageDriver.Drive();
        }
        public void PrintRooms()
        {
            for (int i = 0; i < rooms.Count; i++)
            {
                Console.WriteLine("Room no {0} has wanted temperature of {1}, and real temperature of {2}", i + 1, Modbus.GetIntegerInput(2 * i + 1), Modbus.GetIntegerOutput(i));
            }
            Console.WriteLine("In case of garage... Car is {0}, inner lights {1}, outer lights {2}, gate is {3}", GarageModbusAdapter.IsCarOutside(0) ? "outside" : GarageModbusAdapter.IsCarInside(0) ? "inside" : "neither outside nor inside",
                GarageModbusAdapter.AreInnerLightsOn(0) ? "on" : "off", GarageModbusAdapter.AreOuterLightsOn(0) ? "on" : "off",
                GarageModbusAdapter.IsGateOpened(0) ? "opened" : GarageModbusAdapter.IsGateClosed(0) ? "closed" : "neither opened nor closed");
            Console.WriteLine();
        }
    }
}
