using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ManagerEmployee
    {
        
        public Worker employee
        {
            get;set;
        }

      
        public ManagerEmployee managerEmployee
        {
            get;set;
        }
        public List<Worker> employees;
        public List<Task> tasks;

        public ManagerEmployee(ManagerEmployee mE)
        {
            this.employees = new List<Worker>();
        }

        public ManagerEmployee()
        {
        }

        public Worker GetDirector(Worker worker, Worker director)
        {
            if(worker.director != null)
            {
                worker.director.dependents.Remove(worker);
            }
            worker.director = director;
            director.dependents.Add(worker);
            return worker;
        }

        public Worker CreateEmployee(uint id, string name)
        {
            var worker = new Worker(id, name);
            employees.Add(worker);
            return new Worker(id, name);
        }
    }
}
