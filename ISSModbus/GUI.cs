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
            int res;
            if(int.TryParse(tpt1.Text, out res))
                b.SetWantedTemperatureToRoomN(0, res);
        }

        private void tpt2_TextChanged(object sender, EventArgs e)
        {
            int res;
            if (int.TryParse(tpt2.Text, out res))
                b.SetWantedTemperatureToRoomN(1, res);
        }

        private void tpt3_TextChanged(object sender, EventArgs e)
        {
            int res;
            if (int.TryParse(tpt3.Text, out res))
                b.SetWantedTemperatureToRoomN(2, res);
        }

        private void tpt4_TextChanged(object sender, EventArgs e)
        {
            int res;
            if (int.TryParse(tpt4.Text, out res))
                b.SetWantedTemperatureToRoomN(3, res);
        }

        private void behindGarage_Click(object sender, EventArgs e)
        {
            carout = !carout;

            GarageModbusAdapter.SetCarOutside(0, carout);
        }

        private void garage_Click(object sender, EventArgs e)
        {
            carin = !carin;

            GarageModbusAdapter.SetCarInside(0, carin);
        }
    }
}
