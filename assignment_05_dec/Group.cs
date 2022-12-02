using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_05_dec
{
    internal class Group
    {
        public int GroupId;
        public byte GroupLimit;
        private static Student[] students = new Student[0];
        public static Group[] groups = new Group[0];
        public Group(int groupId, byte groupLimit)
        {
            GroupId = groupId;
            GroupLimit = groupLimit;
            Array.Resize(ref groups, groups.Length+1);
            groups[groups.Length - 1] = this;
            Console.WriteLine($"Group No {GroupId} with students' limit of {GroupLimit} was successfully created!");
        }
        public void addStudent(Student student,Group group)
        {
            if (students.Length<group.GroupLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length-1] = student;
                Console.WriteLine($"Student {student.Name} {student.Surname} successfully added!");
            }
            else
            {
                Console.WriteLine($"It is impossible to add the student {student.Name} {student.Surname}. Group is already full!\n");
                Program.wantToAddStudent = false;
            }
        }
        public static void getStudents()
        {
            //Console.WriteLine($"Group No {GroupId} students:");
            //foreach (Student student in students)
            //{
            //    string indexStr = (Array.IndexOf(students, student)+1).ToString();
            //    Console.WriteLine($"{indexStr}. {student}");
            //}
            //foreach (Group groupp in groups)
            //{
            //    Console.WriteLine($"Group No {groupp.GroupId} students:");
            //    foreach (Student student in students)
            //    {
            //        string indexStr = (Array.IndexOf(students, student) + 1).ToString();
            //        Console.WriteLine($"{indexStr}. {student}");
            //    }
            //}
            foreach (Group groupp in groups)
            {
                Console.WriteLine($"Group No {groupp.GroupId} students:");
                foreach (Student student in students)
                {
                    if (student.GroupName == groupp)
                    {
                        Console.WriteLine(student);
                    }
                }
            }
        }
        public override string ToString()
        {
            return GroupId.ToString();
        }
    }
}
