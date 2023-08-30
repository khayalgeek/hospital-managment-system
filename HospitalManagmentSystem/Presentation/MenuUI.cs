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
            var menu = new EasyConsole.Menu()
               .Add("Doctors", () => MenuService.DisplayDoctors())

               .Add("Add Doctor", () => MenuService.AddDoctorMenu())

               .Add("Delete Doctor", () => MenuService.DeleteItemType("doctor"))

               .Add("Pasients", () => MenuService.DisplayPasient())

               .Add("Add Pasient", () => MenuService.AddPasientMenu())

               .Add("Delete Pasient", () => MenuService.DeleteItemType("pasient"))

               .Add("Meetings", () => MenuService.DisplayMeetings())

               .Add("Add Meeting", () => MenuService.AddMeetingMenu())

               .Add("Delete Meeting", () => MenuService.DeleteItemType("meeting"))

               .Add("Report", () => MenuService.ReportMenu())

               .Add("Exit", () => Console.WriteLine("Good Bye"));

            menu.Display();
        }
    }
}
