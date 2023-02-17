using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }
        public long IDNP { get; set; }
        public DateTime BirthDate { get; set; }
        public List<double> Grades { get; set; }
        public int EnrollmentYear { get; set; }
    }
}
