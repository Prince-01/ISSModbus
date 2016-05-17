using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISSModbus
{
    public partial class GUI : Form
    {
        Building b = new Building(4);
        bool carin = false;
        bool carout = false;

        public GUI()
        {
            InitializeComponent();
            b.SetWantedTemperatureToRoomN(0, 20);
            b.SetWantedTemperatureToRoomN(1, 20);
            b.SetWantedTemperatureToRoomN(2, 20);
            b.SetWantedTemperatureToRoomN(3, 20);

            
        }

        private void DrivingTimer_Tick(object sender, EventArgs e)
        {
            b.Drive();

            tp1.Text = "Temperatura: " + b.GetTemperatureForRoomN(0);
            tp2.Text = "Temperatura: " + b.GetTemperatureForRoomN(1);
            tp3.Text = "Temperatura: " + b.GetTemperatureForRoomN(2);
            tp4.Text = "Temperatura: " + b.GetTemperatureForRoomN(3);

            innerLights.BackColor = b.GetInnerLightsOnForGarageN(0) ? Color.Yellow : Color.Black;
            outerLights.BackColor = b.GetOuterLightsOnForGarageN(0) ? Color.Yellow : Color.Black;
            gate.BackColor = b.GetGateOpenedForGarageN(0) ? Color.Green : b.GetGateClosedForGarageN(0) ? Color.Red : Color.Gray;
            behindGarage.BackColor = carout ? Color.Gold : Color.Gray;
            garage.BackColor = carin ? Color.Gold : Color.Gray;
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void steerTempButton_Click(object sender, EventArgs e)
        {
            DrivingTimer.Enabled = !DrivingTimer.Enabled;
        }

        private void tpt1_TextChanged(object sender, EventArgs e)
        {
            b.SetWantedTemperatureToRoomN(0, int.Parse(tpt1.Text));
        }

        private void tpt2_TextChanged(object sender, EventArgs e)
        {
            b.SetWantedTemperatureToRoomN(1, int.Parse(tpt2.Text));
        }

        private void tpt3_TextChanged(object sender, EventArgs e)
        {
            b.SetWantedTemperatureToRoomN(2, int.Parse(tpt3.Text));
        }

        private void tpt4_TextChanged(object sender, EventArgs e)
        {
            b.SetWantedTemperatureToRoomN(3, int.Parse(tpt4.Text));
        }

        private void behindGarage_Click(object sender, EventArgs e)
        {
            carout = !carout;

            GarageModbusAdapter.SetCarOutside(0, carin);
        }

        private void garage_Click(object sender, EventArgs e)
        {
            carin = !carin;

            GarageModbusAdapter.SetCarInside(0, carin);
        }
    }
}
