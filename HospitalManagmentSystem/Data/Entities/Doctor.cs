using HospitalManagmentSystem.Data.Common;

namespace HospitalManagmentSystem.Data.Entities
{
    public class Doctor : BaseEntity
    {
        private static int _count = 0;
        public Doctor()
        {
            _count++;
            No = _count;
        }

        public string Fullname { get; set; }
        public string Department { get; set; }
        public double PricePerSession { get; set; }
    }
}