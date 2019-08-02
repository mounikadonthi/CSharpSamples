namespace SwitchboardSimulation
{
   public class Appliance
    {
        public string name
        {
            get;
            set;
        }
        public Appliance(string name)
        {
            this.name = name;
        }
 
    }
   public class Ac : Appliance
    {
        public Ac(string name):base(name)
        {
        
        }
    }
   public class Bulb : Appliance
    {
        public Bulb(string name):base(name)
        {
            
        }
     }
    public class Fan : Appliance
    {
        public Fan(string name):base(name)
        {
            
        }
    }
}
