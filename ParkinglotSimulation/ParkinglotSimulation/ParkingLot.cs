using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkinglotSimulation
{
    class ParkingLot
    {
        public List<Slot> Slots
        {
            get;
            set;
        }
        public List<Ticket> Tickets
        {
            get;
            set;
        }
        public ParkingLot()
        {
            this.Slots = new List<Slot>();
            this.Tickets = new List<Ticket>();
        }
      
    }
}
