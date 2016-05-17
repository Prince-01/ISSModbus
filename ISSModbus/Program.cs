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
            GUI gui = new GUI();
            gui.ShowDialog();
        }
    }
}
