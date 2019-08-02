namespace SwitchboardSimulation
{
    interface ISwitch
    {
        void toggleState();
    }
    public enum SwitchStatus
    {
        off,
        on        
    }
    public class Switch : ISwitch
    {
        public int id
        {
            get;
            set;
        }
        public SwitchStatus Status
        {
            get;
            set;
        }
        public Appliance ApplianceName
        {
            get;
            set;
        }

        public Switch()
        {

        }
        public Switch(SwitchStatus status, int id, Appliance applianceName)
        {
            this.Status = status;
            this.id = id;
            this.ApplianceName = applianceName;
        }
         public void toggleState()
         {    
             this.Status = this.Status == SwitchStatus.off ?  SwitchStatus.on : SwitchStatus.off;
         }
    }
}
