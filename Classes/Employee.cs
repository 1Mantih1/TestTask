using System;

namespace TestTask.Classes
{
    public class Employee
    {
        public string Fio { get; set; }
        public string Status { get; set; }
        public string Department { get; set; }
        public string Post { get; set; }
        public DateTime? DateOfAdm { get; set; }
        public DateTime? DateOfDis { get; set; }

        public Employee(string fio, string status, string department, string post, DateTime? dateOfAdm, DateTime? dateOfDis)
        {
            Fio = fio;
            Status = status;
            Department = department;
            Post = post;
            DateOfAdm = dateOfAdm;
            DateOfDis = dateOfDis;
        }
    }
}
