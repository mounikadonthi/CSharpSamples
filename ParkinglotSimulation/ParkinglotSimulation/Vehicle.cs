using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkinglotSimulation
{
  public class Vehicle
    {
          public int VehicleNumber
            {
                get;
                set;
            }
            public VehicleType VehicleType
            {
                get;
                set;
            }

        public Vehicle(VehicleType vehicleType, int VehicleNumber)
        {
           
            this.VehicleType = vehicleType;
            this.VehicleNumber = VehicleNumber;
        }
        public Vehicle()
        {
           

        }
    }
    class FourWheelerVehicle : Vehicle
    {
        public FourWheelerVehicle(VehicleType vehicleType, int VehicleNumber):base( vehicleType,  VehicleNumber)
        {
        }
    }
    class HeavyVehicle : Vehicle
    {
        public HeavyVehicle(VehicleType vehicleType, int VehicleNumber) : base(vehicleType, VehicleNumber)
        {
            
        }
    }

    class TwoWheelerVehicle : Vehicle
    {

        public TwoWheelerVehicle(VehicleType vehicleType, int VehicleNumber) : base(vehicleType, VehicleNumber)
        {
         
        }
    }


}
