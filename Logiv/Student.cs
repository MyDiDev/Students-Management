using Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logiv
{
    public class Student
    {
        public string Name;
        public string Plate;
        public int Age;
        public string PhoneNumber;


        public Student(string name, string plate, int age, string phoneNumber)
        {
            Name = name;
            Plate = plate;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        public Student(string name, string plate)
        {
            Plate = plate;
            Name = name;
        }

        public Student(string name)
        {
            Name = name;
        }

        public Student() { }

        ~Student() { }

        public bool AddStudent() => conn.addEstudiante(Name, Plate, Age, PhoneNumber);
        public bool RemoveStudent(int id) => conn.delEstudiante(id);
        public bool ModifiyStudent(int id) => conn.uptEstudiante(id, Name, Plate, Age, PhoneNumber);
        public DataTable GetStudents() => conn.consultEstudiante();
        public List<string> GetPlates() => conn.GetMatriculas(Name);
        public List<string> GetPlates(int id) => conn.GetMatriculas(id);
        public int GetId() => conn.getIdStudent(Name, Plate);
        public string getName(int id) => conn.getStudentName(id);

    }
}
