using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = DAL.Task;

namespace BLL
{
    public class SearchById : ISearch
    {
        public List<Task> tasks = new List<Task>();
        public uint Id
        {
            get;set;
        }
        public DateTime Data 
        { 
            get; set; 
        }

        public SearchById(List<Task> tasks, uint id)
        {
            
            Id = id;
        }

        public DAL.Task Searching()
        {
            var tk = new Task();
            foreach(var t in tasks)
            {
                if (t.Id == Id)
                {
                    tk = t;
                    return t;
                }
            }
            return tk;
        }

       
    }
    public class SearchByDate : ISearch
    {
        public List<Task> tasks;
        public DateTime Data
        {
            get;set;
        }
        public uint Id 
        { 
            get; set; 
        }

        public SearchByDate(DateTime data, List<Task> tasks)
        {
            Data = data;
            this.tasks = new List<DAL.Task>();
            
        }
        public Task Searching()
        {
            return tasks.Find(task => task.CreationTime == Data);
            return tasks.Where(task => task.CreationTime == Data).FirstOrDefault();
        }
    }
    public class SearchByEmployee : ISearch
    {
        public Worker empl;
        public List<Task> task;
        public uint Id 
        { 
            get; set; 
        }
        public DateTime Data 
        { 
            get; set; 
        }
        public SearchByEmployee(List<Task> tasks, Worker worker)
        {
           
            this.task = new List<DAL.Task>();
            this.empl = worker;
            

        }
        public List<Task> tasks;

        public Task Searching()
        {
            return tasks.Find(task => task.employee == empl);
        }
    }
    public class SearchByChanges : ISearch
    {
        public List<Task> tasks;
        
        public DateTime Data 
        { 
            get; set; 
        }
        public uint Id 
        { 
            get; set; 
        }

        public SearchByChanges(List<Task> tasks, DateTime data)
        {
            this.tasks = tasks;
            Data = data;
        }

        public Task Searching()
        {
            return tasks.Find(task => task.UpDate == Data);
        }
    }
}
