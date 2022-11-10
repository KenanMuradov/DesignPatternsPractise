﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample.ImplementationLayer.Interfaces;

public interface ILEDTV
{
    void SwitchOn();
    void SwitchOff();
    void SetChannel(int channelNumber);
}
