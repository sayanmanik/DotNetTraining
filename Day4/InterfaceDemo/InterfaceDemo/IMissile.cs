﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IMissile : IFlight, IWeapon
    {
        void bombard();
    }
}
