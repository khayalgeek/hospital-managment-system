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

                .Add("Delete Doctor", () => MenuService.DeleteItemType("doctor"))

                .Add("Pasients", () => MenuService.DisplayPasient())

                .Add("Add Pasient", () => MenuService.AddPasientMenu())

                .Add("Delete Pasient", () => MenuService.DeleteItemType("pasient"))

                .Add("Meetings", () => MenuService.DisplayMeetings())

                .Add("Add Meeting", () => MenuService.AddMeetingMenu())

                .Add("Delete Meeting", () => MenuService.DeleteItemType("meeting"))

                .Add("Report", () => MenuService.DisplayDoctors())

                .Add("Exit", () => MenuService.DisplayDoctors());

            menu.Display();
        }
    }
}