﻿namespace Devices.Entities
{
    public abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string doc);

    }
}