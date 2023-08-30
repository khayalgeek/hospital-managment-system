using HospitalManagmentSystem.Data.Common;

namespace HospitalManagmentSystem.Data.Entities
{
    public class Pasient : BaseEntity
    {
        private static int _count = 0;
        public Pasient()
        {
            _count ++;
            No = _count;
        }
        public string Fullname { get; set; }
        public string Phone { get; set; }
    }
}