using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    internal class Student : MemberRecord
    {
        public int studentId {  get; set; }
        public string schoolName { get; set; }

        public Student(int studentId, string schoolName)
        {
            this.studentId = studentId;
            this.schoolName = schoolName;
        }
    }
}
