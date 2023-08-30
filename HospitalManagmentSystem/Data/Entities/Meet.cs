using HospitalManagmentSystem.Data.Common;
using System;

namespace HospitalManagmentSystem.Data.Entities
{
    public class Meet : BaseEntity
    {
        private static int _count = 0;
        public Meet()
        {
            _count++;
            No = _count;
            Date = DateTime.Now;
        }
        public Doctor Doctor { get; set; }
        public Pasient Pasient { get; set; }
        public DateTime Date { get; set; }
        public string Result { get; set; }
    }
}