using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkinglotSimulation
{
           class Slot
            {
                public int SlotNumber
                {
                    get;
                    set;
                }
                public SlotType slotType
                {
                    get;
                    set;
                }
                public Vehicle vehicle
                {
                    get;
                    set;
                }
                public bool IsOccupied
                {
                    get;
                    set;
                }
                public Slot(int SlotNumber, bool IsOccupied, SlotType slotType)
                {
                    this.slotType = slotType;
                    this.SlotNumber = SlotNumber;
                    this.IsOccupied = IsOccupied;
                }
                public Slot()
                {
          
                }
               public bool CheckAvailableSlot(SlotType type, List<Slot> slots)
                {
                    int _SlotCount = slots.Where(slot => slot.IsOccupied == false && slot.slotType == type).Count();
                    return _SlotCount == 0 ? false: true;
                }
               public Slot GetAvailableSlotNumber(SlotType type, List<Slot> slots)
                {
                  return slots.FirstOrDefault(slot => slot.IsOccupied == false && slot.slotType == type);
                    //if (_Slot != null)
                    //    return _Slot.SlotNumber;
                    //else
                    //    return null;
                }

                public Ticket ParkVechile(Vehicle vehicle, int? slotNumber)
                {
                    this.IsOccupied = true;
                    this.vehicle = vehicle;
                    return new Ticket(vehicle.VehicleNumber, slotNumber, DateTime.Now, Guid.NewGuid() ); 
                }
               // ParkingLot parkingLot = new ParkingLot();
                public Vehicle  VehicleToUnPark()
                  {

                        this.IsOccupied = false;
                        var currentVehicle = this.vehicle;
                        this.vehicle = null;
                        return currentVehicle;
                  }
                public void OccupancyDetails(List<Slot> slots)
                {
                    Console.WriteLine("Currently filled two wheeler vehicle slots:  {0}/{1}", slots.Where(slot => slot.IsOccupied == true && slot.slotType == SlotType.TwoWheeler).Count(), slots.Where(slot => slot.slotType == SlotType.TwoWheeler).Count());
                    Console.WriteLine("Currently filled four wheeler vehicle slots:  {0}/{1}", slots.Where(slot => slot.IsOccupied == true && slot.slotType == SlotType.FourWheeler).Count(), slots.Where(slot => slot.slotType == SlotType.FourWheeler).Count());
                    Console.WriteLine("Currently filled heavy wheeler vehicle slots:  {0}/{1}", slots.Where(slot => slot.IsOccupied == true && slot.slotType == SlotType.HeavyVehicle).Count(), slots.Where(slot => slot.slotType == SlotType.HeavyVehicle).Count());
                }
            }
    }

