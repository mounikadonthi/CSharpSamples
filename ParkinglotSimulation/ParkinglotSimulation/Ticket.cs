using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkinglotSimulation
{
    class Ticket
    {
        public Guid TicketNumber
        {
            get;
            set;
        }
        public int VehicleNumber
        {
            get;
            set;
        }
        public int? SlotNumber
        {
            get;
            set;
        }
        public DateTime InTime
        {
            get;
            set;
        }
        public DateTime OutTime
        {
            get;
            set;
        }
        public Ticket(int VehicleNumber, int? SlotNumber, DateTime InTime, Guid TicketNumber)
        {
            this.TicketNumber = TicketNumber;
            this.InTime = InTime;
            this.VehicleNumber = VehicleNumber;
            this.SlotNumber = SlotNumber;
        }
        public override string ToString()
        {
            return "\t VehicleNumber:" + VehicleNumber + "\n\t" + " SlotNumber:" + SlotNumber + "\n\t" + " InTime:" + InTime + "\n\t" + " TicketNumber:"+TicketNumber;
        }
        public Ticket()
        {
      
        }
    }
}
