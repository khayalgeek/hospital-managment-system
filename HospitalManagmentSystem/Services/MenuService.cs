using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem.Services
{
    public static class MenuService
    {
        static HospitalService hospitalService = new();
        
        public static void DisplayDoctors()
        {
            var table = new ConsoleTable("No", "Fullname", "Department", "Session Price");

            foreach (var doctor in hospitalService.Doctors)
            {
                table.AddRow(doctor.No, doctor.Fullname, doctor.Department, doctor.PricePerSession.ToString("#.00"));
            }
            table.Write();
        }
    }
}
