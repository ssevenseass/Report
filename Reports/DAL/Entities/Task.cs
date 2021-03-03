using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Task
    {
        public string Name
        {
            get; set;
        }
        public uint Id
        {
            get; set;
        }
        public string Comment
        {
            get; set;
        }
        public States stateTask
        {
            get; set;
        }
        public DateTime CreationTime
        {
            get; set;
        }
        public Worker employee
        {
            get; set;
        }
        public DateTime UpDate
        {
            get; set;
        }

        public Task(string name, uint id, string comment, States stateTask)
        {
            Name = name;
            Id = id;
            Comment = comment;
            this.stateTask = stateTask;
        }
        public Task(uint id, string name, Worker employee, string comment)
        {
            Id = id;
            Name = name;
            this.employee = employee;
            Comment = comment;


        }

        public Task(uint id)
        {
            Id = id;
        }
        public Task()
        {

        }
    }
}