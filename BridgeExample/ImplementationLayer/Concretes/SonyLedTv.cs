﻿using BridgeExample.ImplementationLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample.ImplementationLayer.Concretes;

public class SonyLedTv : ILEDTV
{
    public void SwitchOn()
    {
        Console.WriteLine("Turning ON : Sony TV");
    }
    public void SwitchOff()
    {
        Console.WriteLine("Turning OFF : Sony TV");
    }
    public void SetChannel(int channelNumber)
    {
        Console.WriteLine("Setting channel Number " + channelNumber + " on Sony TV");
    }
}
