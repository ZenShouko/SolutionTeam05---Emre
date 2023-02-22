using ClassLibTeam05.Business.Entities;
using ClassLibTeam05.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibTeam05.Business
{
    public static class Students
    {
        //Added Static to fix error
        public static IEnumerable<Student> List()
        {
            return StudentRepository.StudentList;
        }

        public static void Add(string firstName, string lastName) 
        { 
            StudentRepository.Add(firstName, lastName); 
        }
    }
}
