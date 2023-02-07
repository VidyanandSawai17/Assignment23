using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Assignment23
{
    public class StudentCRUD
    {
        private List<Student> students;

        public StudentCRUD() 
        {

            students = new List<Student>()
        {
            new Student{id = 1, name = "Ram", branch = "IT"},
            new Student{id = 2, name = "Shyam", branch = "MECH"},
            new Student{id = 3, name = "Rahul", branch = "EXTC"}

        };
        }


        public void AddStudent(Student stud)
        {
            students.Add(stud);
        }

        public void UpdateStudent(Student stud) 
        { 
        for (int i = 0; i < students.Count; i++)
            {
                
                if (students[i].id == stud.id)
                {
                    students[i].name = stud.name;
                    students[i].branch = stud.branch;
                    break;

                }
            }
        
        
        }
        public void RemoveStudent(int id)
        {
            for (int i = 0; i < students.Count; i++)
            {
                
                if (students[i].id == id)
                {
                    students.RemoveAt(i);
                    break;

                }
            }
        }

        public List<Student> List()
        {
            return students;
        }

        public Student ViewStudentId(int id)
        {
            Student student = new Student();  
            for (int i = 0; i < students.Count; i++)
            {

                if (students[i].id == id)
                {
                    student = students[i];
                    break;

                }
            }
            return student;
        }


    }
}
