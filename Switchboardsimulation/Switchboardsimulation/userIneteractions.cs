using System;
namespace SwitchboardSimulation
{
    public class userIneteractions
        {
            public static void Main(String[] args)
             {
                    int noOffans, noOfBulbs, noOfAcs, noOfSwitches;
                    Console.WriteLine("Please Enter Number Of Fans");
                    noOffans = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please Enter Number Of ACs");
                    noOfAcs = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please Enter Number Of Bulbs");
                    noOfBulbs = Convert.ToInt32(Console.ReadLine());
                    userIneteractions userinterface = new userIneteractions();
                    SwitchBoard switchBoard = new SwitchBoard();
         
                    for (int i = 1; i <= noOffans; i++)
                     {
                        Appliance fan = new Fan("fan" + i);
                        switchBoard.CreateSwitch(fan);
                     }
                    for (int i = 1; i <= noOfAcs; i++)
                     {
                        Appliance ac = new Ac("ac" + i);
                        switchBoard.CreateSwitch(ac);
                     }
                    noOfSwitches = noOfAcs + noOfBulbs + noOffans;
                    for (int i = 1; i <= noOfBulbs; i++)
                     {
                        Appliance bulb = new Bulb("bulb" + i);
                        switchBoard.CreateSwitch(bulb);
                     }
                    if (noOfSwitches == 0)
                     {
                        System.Environment.Exit(1);
                     }
                    userinterface.DisplaySwitchList(switchBoard);
                    userinterface.chooseSwitch(switchBoard);
             }

            public void DisplaySwitchList(SwitchBoard switchBoard)
            {
                foreach (Switch _switch in switchBoard.GetSwitches())
                {
                    Console.WriteLine(_switch.id + " " + _switch.ApplianceName.name + " " + "is" + " " + _switch.Status);
                }
            }
           public void chooseSwitch(SwitchBoard switchboard)
            {
              while (true)
                {
                    Console.WriteLine("select any device by entering its number to change its state");
                    int selectedSwitchId = Convert.ToInt32(Console.ReadLine());
                    switchboard.GetSelectedSwitch(selectedSwitchId);
                    int selectedChoice = 0;
                    var SelectedSwitch= switchboard.GetSelectedSwitch(selectedSwitchId);
                    Console.WriteLine("1.{0} switch is {1}", SelectedSwitch.ApplianceName.name, SelectedSwitch.Status == SwitchStatus.off ? SwitchStatus.on : SwitchStatus.off);
                    Console.WriteLine("2.Back");
                    Console.WriteLine("3.exit");
                    Console.WriteLine("select a choice");
                    selectedChoice = Convert.ToInt32(Console.ReadLine());
                    if (selectedChoice == 1)
                      {
                        SelectedSwitch.toggleState();
                        DisplaySwitchList(switchboard);
                      }
                    if (selectedChoice == 2)
                      {
                          DisplaySwitchList(switchboard);
                      }
                    if (selectedChoice == 3)
                      {
                         System.Environment.Exit(1);
                      }
                }
            }
        }
   }
