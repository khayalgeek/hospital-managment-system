using HospitalManagmentSystem.Services;

namespace HospitalManagmentSystem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var menu = new EasyConsole.Menu()
                .Add("Doctors", () => MenuService.DisplayDoctors()) 

                .Add("Add Doctor", () => MenuService.AddDoctorMenu())

                .Add("Delete Doctor", () => MenuService.DeleteDoctorMenu())

                .Add("Pasients", () => MenuService.DisplayPasient())

                .Add("Add Pasient", () => MenuService.AddPasientMenu())

                .Add("Delete Pasient", () => MenuService.DeletePasientMenu())

                .Add("Meetings", () => MenuService.DisplayMeetings())

                .Add("Add Meeting", () => MenuService.AddMeetingMenu())

                .Add("Delete Meeting", () => MenuService.DeleteMeetingMenu())

                .Add("Report", () => MenuService.DisplayDoctors())

                .Add("Exit", () => MenuService.DisplayDoctors());

            menu.Display();
        }
    }
}