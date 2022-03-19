using System;
using System.Collections.Generic;

namespace Taxi.Data.Models
{
    public partial class CarOptions
    {
        public CarOptions()
        {
            Cars = new HashSet<Car>();
        }

        public int CarOptionsId { get; set; }
        public bool? Autopilot { get; set; }
        public bool? ActiveAirbag { get; set; }
        public bool? UsbPort { get; set; }
        public bool? Multimedia { get; set; }
        public string EngineMode { get; set; }

        public CarOptions(int carOptionsId, bool autoPilot, bool activeAirbag, bool usbPort, bool multimedia, string engineMode)
        {
            this.CarOptionsId = carOptionsId;
            this.Autopilot = autoPilot;
            this.ActiveAirbag = activeAirbag;
            this.UsbPort = usbPort;
            this.Multimedia = multimedia;
            this.EngineMode = engineMode;
        }

        public CarOptions(int carOptionsId, string engineMode)
        {
            this.CarOptionsId = carOptionsId;
            this.EngineMode = engineMode;
        }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
