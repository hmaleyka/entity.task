using EntityFramework.Task.DAL;
using EntityFramework.Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Task.Services
{
    internal class StudentServices
    {
        private AppDbContext _appDbContext;

        public StudentServices()
        {
            _appDbContext = new AppDbContext();
        }
        public void AddStudent(Student student)
        {
            _appDbContext.students.Add(student);
            _appDbContext.SaveChanges();
        }

        public void DeleteStudent(int studentId)
        {
            var oldstudent = _appDbContext.students.FirstOrDefault(x => x.Id == studentId);
            if (oldstudent != null)
            {
                _appDbContext.students.Remove(oldstudent);
                _appDbContext.SaveChanges();
                Console.WriteLine("It was deleted succesfully"); ;
            }
        }


        public void UpdateStudent(Student student)
        {
            var oldstudent = _appDbContext.students.FirstOrDefault(x=> x.Id == student.Id);
            if (oldstudent != null)
            {
                oldstudent.Name = student.Name;
               
                _appDbContext.Update(oldstudent);
                

                _appDbContext.SaveChanges();
                Console.WriteLine("Value was updated succesfully:");
            }

        }

        public List <Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            return _appDbContext.students.ToList();
        }

        public void GetStudent(int studentId)
        {
            var getstudent = _appDbContext.students.FirstOrDefault(s => s.Id == studentId);
            Console.WriteLine($"Name: {getstudent.Name} , Surname: {getstudent.Surname}");
        }






    }
}
