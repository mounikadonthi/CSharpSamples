using System.Collections.Generic;
using System.Linq;

namespace SwitchboardSimulation
{
    public class SwitchBoard
    {
        private List<Switch> Switches
        {
            get;
            set;
        }
        public SwitchBoard()
        {
            this.Switches = new List<Switch>();
        }
        public void CreateSwitch( Appliance appliance)
        {
            this.Switches.Add(new Switch(SwitchStatus.off, this.Switches.Count + 1, appliance));
        }

        public List<Switch> GetSwitches()
        {
            return this.Switches;
        }
        public Switch GetSelectedSwitch( int id)
        {
            return Switches.FirstOrDefault(_switch => _switch.id == id);
        }


    }
}
