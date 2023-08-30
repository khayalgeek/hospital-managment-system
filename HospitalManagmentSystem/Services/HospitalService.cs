using HospitalManagmentSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalManagmentSystem.Services
{
    public class HospitalService
    {
        public List<Doctor> Doctors { get; private set; }
        public List<Pasient> Pasients { get; private set; }
        public List<Meet> Meets { get; private set; }

        public HospitalService()
        {
            Doctors = new();
            Pasients = new();
            Meets = new();
        }

        #region Doctor

        public int AddDoctor(string fullname, string department, double pricePerSession)
        {
            if (string.IsNullOrEmpty(fullname))
                throw new ArgumentNullException(nameof(fullname));

            if (string.IsNullOrEmpty(department))
                throw new ArgumentNullException(nameof(department));

            if (pricePerSession <= 0)
                throw new ArgumentOutOfRangeException(nameof(pricePerSession));

            Doctor doctor = new();
            doctor.Fullname = fullname;
            doctor.Department = department;
            doctor.PricePerSession = pricePerSession;
            Doctors.Add(doctor);

            return doctor.No;
        }

        public void DeleteDoctor(int no)
        {
            int index = Doctors.FindIndex(d => d.No == no);
            if (index == -1)
                throw new KeyNotFoundException();

            Doctors.RemoveAt(index);
        }

        #endregion Doctor

        #region Pasient

        public int AddPasient(string fullname, string phone)
        {
            if (string.IsNullOrEmpty(fullname))
                throw new ArgumentNullException(nameof(fullname));

            if (string.IsNullOrEmpty(phone))
                throw new ArgumentNullException(nameof(phone));

            Pasient pasient = new();
            pasient.Fullname = fullname;
            pasient.Phone = phone;

            Pasients.Add(pasient);

            return pasient.No;
        }

        public void DeletePasient(int no)
        {
            int index = Pasients.FindIndex(pas => pas.No == no);

            if (index == -1)
                throw new KeyNotFoundException();

            Doctors.RemoveAt(index);
        }

        #endregion Pasient

        #region Meet

        public int AddMeet(int doctorNo, int pasientNo, string result)
        {
            if (string.IsNullOrEmpty(result))
                throw new ArgumentNullException(nameof(result));

            var doctor = Doctors.FirstOrDefault(d => d.No == doctorNo);

            if (doctor is null)
                throw new KeyNotFoundException();

            var pasient = Pasients.FirstOrDefault(p => p.No == pasientNo);

            if (pasient is null)
                throw new KeyNotFoundException();

            Meet meet = new();
            meet.Doctor = doctor;
            meet.Pasient = pasient;
            meet.Result = result;

            Meets.Add(meet);

            return meet.No;
        }

        public void DeleteMeet(int no)
        {
            int index = Meets.FindIndex(pas => pas.No == no);

            if (index == -1)
                throw new KeyNotFoundException();

            Doctors.RemoveAt(index);
        }

        #endregion Meet

        #region Report

        public Report RecordReport(DateTime startDate, DateTime finishDate)
        {
            var meets = Meets.Where(m => m.Date >= startDate && m.Date <= finishDate);

            Report report = new();
            report.MeetCount = meets.Count();
            report.Income = meets.Sum(m => m.Doctor.PricePerSession);

            return report;
        }

        #endregion Report
    }
}