using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment23
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentCRUD studentCRUD = new StudentCRUD();
            int c = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Students List");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Search Student");
                Console.WriteLine("Enter a No 1 to 4");
                int op;
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
            {
                case 1:
                        List<Student> stud = studentCRUD.List();
                        Console.WriteLine("Id \t Name \t\t Branch");

                        for (int i = 0; i < stud.Count; i++)
                        {
                            Console.WriteLine(i);
                        }
                        
                        
                        
                        
                        
                        
                        /*foreach (Student s in stud)
                        {
                            Console.WriteLine($"{s.id} \t {s.name} \t\t {s.branch}");
                        }*/
                        break;

                case 2:
                        Student s1 = new Student();
                        Console.WriteLine("Enter Id");
                        s1.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter student name");
                        s1.name = Console.ReadLine();
                        Console.WriteLine("Enter Branch");
                        s1.branch = Console.ReadLine();

                        studentCRUD.AddStudent(s1);

                        Console.WriteLine("Student added..");

                        break;
                    
                    
                    
                case 3:

                        Student s2 = new Student();
                        Console.WriteLine("Enter Id");
                        s2.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter student name");
                        s2.name = Console.ReadLine();
                        Console.WriteLine("Enter Branch");
                        s2.branch = Console.ReadLine();

                        studentCRUD.UpdateStudent(s2);

                        Console.WriteLine("Student Updated..");

                        break;

                        case 4:

                        Console.WriteLine("Enter Id to delete");
                        int id = Convert.ToInt32(Console.ReadLine());
                        studentCRUD.RemoveStudent(id);
                        Console.WriteLine("Product deleted..");

                        break;

                        case 5:

                        Console.WriteLine("Enter Id to delete");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        Student student = studentCRUD.ViewStudentId(id1);
                        if (student.id > 0)
                            Console.WriteLine($"Id = {student.id} , Name ={student.name}, Price= {student.branch}");
                        else
                            Console.WriteLine("Student not found..");
                        break;


                        break;




                }
                       Console.WriteLine("1 of Continue");
                       c = Convert.ToInt32(Console.ReadLine());

            } while (c==1);
        }
    }
}
