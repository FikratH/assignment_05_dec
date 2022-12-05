namespace assignment_05_dec
{
    internal class Program
    {
        public static bool wantToAddStudent;
        public static bool wantToAddGroup;
        static void Main(string[] args)
        {
            Group group2;
            do
            {
                Console.WriteLine($"Do you wish to add a group? y/n");
                if (char.ToLower(Console.ReadKey().KeyChar) == 'y')
                {
                    Console.WriteLine("\n");
                    wantToAddGroup= true;
                    Console.WriteLine("Please enter the group ID: ");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please, enter the limit of students in group " + id1);
                    byte limit1 = Convert.ToByte(Console.ReadLine());
                    group2 = new Group(id1, limit1);
                } else
                {
                    wantToAddGroup= false;
                    Console.WriteLine("\n");
                }
            } while (wantToAddGroup);
            //Console.WriteLine("Please enter the group ID: "); 
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please, enter the limit of students in group " + id);
            //byte limit = Convert.ToByte(Console.ReadLine());
            //Group group = new Group(id, limit);
            do
            {
                Console.WriteLine($"Do you wish to add a student to the group? y/n");
                if (char.ToLower(Console.ReadKey().KeyChar) == 'y')
                {
                    Console.WriteLine("\n");
                    wantToAddStudent = true;
                    Console.WriteLine("Please, select a group to add a student (enter the index of a group)");
                    foreach (Group group1 in Group.groups)
                    {
                        string groupIndexStr = (Array.IndexOf(Group.groups, group1) + 1).ToString();
                        Console.WriteLine($"{groupIndexStr}. {group1}");
                    }
                    int selectedIndex = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("Please, enter the student's name:");
                    string studName = Console.ReadLine();
                    Console.WriteLine("Please, enter the student's surname:");
                    string studSurname = Console.ReadLine();
                    Console.WriteLine("Please, enter the student's subject:");
                    string studSubject = Console.ReadLine();
                    Student student = new Student(studName, studSurname, studSubject, Group.groups[selectedIndex - 1], Group.groups[selectedIndex-1].GroupId);
                }
                else
                {
                    wantToAddStudent = false;
                    Console.WriteLine("\n");
                }
            } while (wantToAddStudent);

            Group.getStudents();
        }
    }
}