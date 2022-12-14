using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_05_dec
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Subject;
        public Group GroupName;
        public int groupID;

        public Student(string name, string surname, string subject, Group groupname,int groupId)
        {
            Name = name;
            Surname = surname;
            Subject = subject;
            GroupName= groupname;
            groupID = groupId;
            groupname.addStudent(this,groupname);
        }
        public override string ToString()
        {
            return $"{Name}, {Surname}, {Subject}";
        }
    }
}
