using System;
using System.Globalization;
using ConsoleTables;

namespace HospitalManagmentSystem.Services
{
    public static class MenuService
    {
        private static HospitalService hospitalService = new();

        #region Display Tables
        public static void DisplayDoctors()
        {
            var table = new ConsoleTable("No", "Fullname", "Department", "Session Price");

            foreach (var doctor in hospitalService.Doctors)
            {
                table.AddRow(doctor.No, doctor.Fullname, doctor.Department, doctor.PricePerSession.ToString("#.00"));
            }
            table.Write();
        }

        public static void DisplayPasient()
        {
            var table = new ConsoleTable("No", "Fullname", "Phone");

            foreach (var pasient in hospitalService.Pasients)
            {
                table.AddRow(pasient.No, pasient.Fullname, pasient.Phone);
            }
            table.Write();
        }

        public static void DisplayMeetings()
        {
            var table = new ConsoleTable("No", "Doctor", "Pasient", "Date", "Result", "Price");

            foreach (var meet in hospitalService.Meets)
            {
                table.AddRow(meet.No, meet.Doctor.Fullname, meet.Pasient.Fullname, meet.Date.ToString("dd.MM.yyyy HH:mm"), meet.Result, meet.Doctor.PricePerSession);
            }
            table.Write();
        }
        #endregion

        #region Add Methods 
        public static void AddDoctorMenu()
        {
            Console.WriteLine("Insert Fullname");
            string fullname = Console.ReadLine();

            Console.WriteLine("Insert Department");
            string department = Console.ReadLine();

            Console.WriteLine("Insert Department");
            string priceStr = Console.ReadLine();

            try
            {
                hospitalService.AddDoctor(fullname, department, double.Parse(priceStr));
                Console.WriteLine("Doctor inserted");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please try again");
                Console.WriteLine(e.Message);
            }

        }

        public static void AddPasientMenu()
        {
            Console.WriteLine("Insert Fullname");
            string fullname = Console.ReadLine();

            Console.WriteLine("Insert Phone");
            string phone = Console.ReadLine();

            try
            {
                hospitalService.AddPasient(fullname, phone);
                Console.WriteLine("Pasient inserted");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please try again");
                Console.WriteLine(e.Message);
            }
        }

        public static void AddMeetingMenu()
        {
            Console.WriteLine("Insert Doctor No");
            string doctorNoStr = Console.ReadLine();

            Console.WriteLine("Insert Pasient No");
            string pasientNoStr = Console.ReadLine();

            Console.WriteLine("Insert Result");
            string result = Console.ReadLine();

            try
            {
                hospitalService.AddMeet(int.Parse(doctorNoStr), int.Parse(pasientNoStr), result);
                Console.WriteLine("Metting inserted");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please try again");
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region Delete Methods
       

       
        #endregion
    }
}