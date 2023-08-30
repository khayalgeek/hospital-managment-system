using HospitalManagmentSystem.Services;
using System;

namespace HospitalManagmentSystem
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            var menu = new EasyConsole.Menu()
                .Add("Doctors", () => MenuService.DisplayDoctors());
            menu.Display();
        }
    }
}