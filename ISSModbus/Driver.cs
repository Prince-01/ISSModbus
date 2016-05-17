using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSModbus
{
    interface Driver
    {
        void Drive();
        void AddObjectToDrive(DrivableObject drivable);
    }
}
