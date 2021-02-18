using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Testapplication.Models;

namespace Testapplication.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class StudentController : ControllerBase
    {
        public static List<Student> GetStudents()
        {
            List<Student> Studentlist = new List<Student>();
            Studentlist.Add(new Student(){Id = 1, FirstName = "Lucas", LastName = "magnifquepersonne", Age = 20});
            Studentlist.Add(new Student(){Id = 2, FirstName = "Alexie", LastName = "filsdunefamme", Age = 19});
            Studentlist.Add(new Student(){Id = 3, FirstName = "tony", LastName = "luiilchooppe", Age = 19});
            Studentlist.Add(new Student(){Id = 4, FirstName = "Anzar", LastName = "chien", Age = 19});
            return Studentlist;
        }

        [HttpGet]
        public IEnumerable<Student> GetStudent_List()
        {
            return GetStudents();
        }

        [HttpGet("namestartingwithA")]
        public IEnumerable<Student> GetStudentWithA()
        {
            List<Student> studentlist = GetStudents();
            studentlist.Add(null);
            List<Student> studentlist2 = new List<Student>();
            int i = 0;
            while (studentlist[i] != null)
            {
                if (studentlist[i].FirstName[0] == 'A')
                {
                    studentlist2.Add(studentlist[i]);
                }
                i++;
            }
            return studentlist2;
        }
    }
}