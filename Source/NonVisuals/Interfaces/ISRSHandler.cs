﻿using NonVisuals.Radios;
using NonVisuals.Radios.SRS;

namespace NonVisuals.Interfaces
{
    public interface ISRSHandler
    {
        bool GuardIsOn { get; set; }
        double Frequency { get; set; }
        double Channel { get; set; }
        SRSRadioMode RadioMode { get; set; }
    }
}
