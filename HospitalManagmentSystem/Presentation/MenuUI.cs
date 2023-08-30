using HospitalManagmentSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HospitalManagmentSystem.Presentation
{
    public static class MenuUI
    {

        public static void Menu()
        {
            //var menu = new EasyConsole.Menu()
            //   .Add("Doctors", () => MenuService.DisplayDoctors())

            //   .Add("Add Doctor", () => MenuService.AddDoctorMenu())

            //   .Add("Delete Doctor", () => MenuService.DeleteItemType("doctor"))

            //   .Add("Pasients", () => MenuService.DisplayPasient())

            //   .Add("Add Pasient", () => MenuService.AddPasientMenu())

            //   .Add("Delete Pasient", () => MenuService.DeleteItemType("pasient"))

            //   .Add("Meetings", () => MenuService.DisplayMeetings())

            //   .Add("Add Meeting", () => MenuService.AddMeetingMenu())

            //   .Add("Delete Meeting", () => MenuService.DeleteItemType("meeting"))

            //   .Add("Report", () => MenuService.ReportMenu())

            //   .Add("Exit", () => Console.WriteLine("Good Bye"));

            //menu.Display();

            int selection = 0;


            do
            {
                Console.WriteLine("1.Doctors");
                Console.WriteLine("2.Add Doctor");
                Console.WriteLine("3.Delete Doctor");
                Console.WriteLine("4.Pasients");
                Console.WriteLine("5.Add Pasient");
                Console.WriteLine("6.Delete Pasient");
                Console.WriteLine("7.Meetings");
                Console.WriteLine("8.Add Meeting");
                Console.WriteLine("9.Delete Meeting");
                Console.WriteLine("10.Report");
                Console.WriteLine("0.Exit");
                Console.WriteLine();
                Console.WriteLine("Please select your option:");
                
                string selectionStr = Console.ReadLine();

                selection = int.Parse(selectionStr);

                switch (selection)
                {
                    case 1:
                        MenuService.DisplayDoctors();
                        break; 
                    case 2:
                        MenuService.AddDoctorMenu();
                        break;
                    case 3:
                        MenuService.DeleteItemType("doctor");
                        break;
                    case 4:
                        MenuService.DisplayPasient();
                        break;
                    case 5:
                        MenuService.AddPasientMenu();
                        break;
                    case 6:
                        MenuService.DeleteItemType("pasient");
                        break;
                    case 7:
                        MenuService.DisplayMeetings();
                        break;
                    case 8:
                        MenuService.AddMeetingMenu();
                        break;
                    case 9:
                        MenuService.DeleteItemType("meeting ");
                        break;
                    case 10:
                        MenuService.ReportMenu();
                        break;
                    case 11:
                        Console.WriteLine("Good bye");
                        break;
                    default:
                        Console.WriteLine("Please try again");
                        break;
                }
            }
            while (selection != 0);
        }
    }
}
