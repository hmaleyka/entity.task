using EntityFramework.Task.DAL;
using EntityFramework.Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Task.Services
{
    internal class GroupServices
    {
        private AppDbContext _appDbContext;

        public GroupServices()
        {
            _appDbContext = new AppDbContext();
        }

        public void AddGroup (Group group)
        {
            _appDbContext.groups.Add(group);
            _appDbContext.SaveChanges();
        }
       

        public void DeleteGroup(int GroupId)
        {
            var oldgroup = _appDbContext.groups.FirstOrDefault(x => x.Id == GroupId);
            if (oldgroup != null)
            {
                _appDbContext.groups.Remove(oldgroup);
                _appDbContext.SaveChanges();
                Console.WriteLine("It was deleted succesfully"); ;
            }
        }


        public void UpdateGroup(Group group)
        {
            var oldgroup = _appDbContext.groups.FirstOrDefault(x => x.Id == group.Id);
            if (oldgroup != null)
            {
                oldgroup.Name = group.Name;

                _appDbContext.Update(oldgroup);
                _appDbContext.SaveChanges();
                Console.WriteLine("The group name was changed successfully");
            }

        }

        public List<Group> GetAllGroups()
        {
            List<Group> groups = new List<Group>();
            return _appDbContext.groups.ToList();
            
        }

        public void GetGroup(int groupId)
        {
            var getgroup = _appDbContext.groups.FirstOrDefault(s => s.Id == groupId);
            Console.WriteLine($"Name: {getgroup.Name} ");
        }
    }

}
