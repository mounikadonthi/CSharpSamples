using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkinglotSimulation
  {
        public enum VehicleType
        {
            TwoWheelerVehicle =1,
            FourWheelerVehicle,
            HeavyVehicle
        }
        public enum SlotType
        {
            TwoWheeler =1,
            FourWheeler =2,
            HeavyVehicle=3
        };
        public class UserInteractions
            {
                static void Main(string[] args)
                     {
                        Console.WriteLine("Please Enter No:Of Twowheeler slots");
                        int noOfTwoWheelerSlots = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please Enter No:Of FourWheeler Slots");
                        int noOfFourWheelerSlots = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please Enter No:Of HeavyWheeler Slots");
                        int noOfHeavyWheelerSlots = Convert.ToInt32(Console.ReadLine());
                        Slot Slot = new Slot();
                        ParkingLot parkingLot = new ParkingLot();
                        for (int i = 1; i <= noOfTwoWheelerSlots; i++)
                        {
                            Slot slot = new Slot(i, false, SlotType.TwoWheeler);
                            parkingLot.Slots.Add(slot);
                        }
                        for (int j = 1; j <= noOfFourWheelerSlots; j++)
                        {
                            Slot slot = new Slot(j, false, SlotType.FourWheeler);
                            parkingLot.Slots.Add(slot);
                        }
                        int totalNoofSlots = noOfTwoWheelerSlots + noOfFourWheelerSlots + noOfHeavyWheelerSlots;
                        for (int k = 1; k <= noOfHeavyWheelerSlots; k++)
                        {
                            Slot slot = new Slot(k, false, SlotType.HeavyVehicle);
                            parkingLot.Slots.Add(slot);
                        }
                        while (true)
                        {
                            Console.WriteLine("1.Park");
                            Console.WriteLine("2.Unpark");
                            Console.WriteLine("3.current occupency");
                            Console.WriteLine("4.Exit");
                            int selectChoice = Convert.ToInt32(Console.ReadLine());
                            Vehicle vehicle = new Vehicle();
                           if (selectChoice == 1)
                            {
                                Console.WriteLine("1." + VehicleType.TwoWheelerVehicle);
                                Console.WriteLine("2." + VehicleType.FourWheelerVehicle);
                                Console.WriteLine("3." + VehicleType.HeavyVehicle);
                                int SlotType = Convert.ToInt32(Console.ReadLine());
                                SlotType selectVehicleType = (SlotType)Enum.ToObject(typeof(SlotType), SlotType);
                                VehicleType selectedVehicleType = (VehicleType)Enum.ToObject(typeof(VehicleType), SlotType);
                                if (Slot.CheckAvailableSlot(selectVehicleType,parkingLot.Slots))
                                {

                                    Slot availableSlot = Slot.GetAvailableSlotNumber(selectVehicleType, parkingLot.Slots);
                                    Console.WriteLine("enter vehicle number");
                                    int VehicleNumber = Convert.ToInt32(Console.ReadLine());
                                    vehicle = new Vehicle(selectedVehicleType, VehicleNumber);
                                    var ticket = parkingLot.Slots.FirstOrDefault(_slot => _slot.SlotNumber == availableSlot.SlotNumber).ParkVechile(vehicle, availableSlot.SlotNumber);
                                    Console.WriteLine("Your Vehicle is parked");
                                    Console.WriteLine("-----------------------------------");
                                    Console.WriteLine(ticket);
                                    Console.WriteLine("------------------------------------");
                                    parkingLot.Tickets.Add(ticket);
                                }
                                else
                                {
                                    Console.WriteLine("sorry no place in parkinglot");
                                }
                            }
                            if (selectChoice == 2)
                            {
                                Console.WriteLine("Please Enter The Ticket Nummber");
                                string ticketNumber = Convert.ToString(Console.ReadLine());
                                Ticket _ticket = parkingLot.Tickets.FirstOrDefault(ticket => ticket.TicketNumber.ToString().ToLower()== ticketNumber.ToLower());
                                if (_ticket != null )
                                {
                                    parkingLot.Slots.FirstOrDefault(slot => slot.SlotNumber == _ticket.SlotNumber).VehicleToUnPark();
                                    Console.WriteLine("your vehicle have been unparked");
                                    Console.WriteLine("------------------------------------");
                                    _ticket.OutTime = DateTime.Now;
                                    Console.WriteLine(_ticket + "\n" + "\t" + " OutTime:" + _ticket.OutTime);
                                    Console.WriteLine("-------------------------------------");
                                }
                            }
                            if (selectChoice == 3)
                              {
                              Slot. OccupancyDetails(parkingLot.Slots);
                              }
                            if (selectChoice == 4)
                            {
                               Environment.Exit(0);
                            }

                      }
               }
       
        }
    
   }
