using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissedAssignment1
{
    enum MonthofAdmin { Jan, Feb, March, Apr, May, June, July, Aug, Sep, Oct, Nov, Dec };
    enum Grades { A, B, C, D, F};
    struct Student
    {
        public int studentID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string cityState { get; set; }
        public MonthofAdmin adminMonth { get; set; }
        public Grades grade { get; set; }

        public Student(int id, string first, string last, string addr, MonthofAdmin m, Grades g)
        {
            this.studentID = id;
            this.firstname = first;
            this.lastname = last;
            this.cityState = addr;
            this.adminMonth = m;
            this.grade = g;
        }
    }
}
