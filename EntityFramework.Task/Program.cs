﻿using EntityFramework.Task.DAL;
using EntityFramework.Task.Models;
using EntityFramework.Task.Services;

namespace EntityFramework.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext appDbContext = new AppDbContext();
            StudentServices studentServices = new StudentServices();
            GroupServices groupServices = new GroupServices();

            Student student1 = new Student()
            {
                Name = "Cristiano",
                Surname = "Ronaldo",

            };

            Student student2 = new Student()
            {
                Name = "Marvel",
                Surname = "Marvelous",

            };

            Student student3 = new Student()
            {
                Name = "Maleyka",
                Surname = "Heybat",

            };
            Student student4 = new Student()
            {
                Name = "zahra",
                Surname = "rzazada",

            };
            Student student5 = new Student()
            {
                Name = "rauf",
                Surname = "Heybat",

            };

            Group group1 = new Group()
            {
                Name = "Eng-30"
            };

            Group group2 = new Group()
            {
                Name = "BB205"
            };
            Group group3 = new Group()
            {
                Name = "BSU_ENG"
            };
            Group group4 = new Group()
            {
                Name = "ENG50"
            };
            Group group5 = new Group()
            {
                Name = "BDU"
            };

            //STUDENTService

            studentServices.AddStudent(student1);
            studentServices.AddStudent(student2);


            foreach (var students in studentServices.GetAllStudents())
            {
                
                Console.WriteLine($"Name: {students.Name} , Surname: {students.Surname}");
            }

            studentServices.DeleteStudent(4);


            Student updatedstudent = new Student
            {
                Id = 3,
                Name = "Wanda",


            };
            studentServices.UpdateStudent(updatedstudent);

            studentServices.GetStudent(3);




            //GROUPSERVICE
            groupServices.AddGroup(group1);
            groupServices.AddGroup(group2);



            foreach (var groups in groupServices.GetAllGroups())
            {
                
                Console.WriteLine($"Name: {groups.Name}");
            }


            groupServices.DeleteGroup(4);

            Group updatedGroup = new Group
            {
                Id = 5,
                Name = "ENG_40",


            };
            groupServices.UpdateGroup(updatedGroup);



            groupServices.GetGroup(5);



        }
    }
    
}