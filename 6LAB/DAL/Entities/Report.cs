using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public enum ReportStatus
    {
        Created,
        Done
    }
    public enum Changes
    {
        AddComment,
        EmployeeChanging,
        StatusChanging
    }

    public class Report : IEntity
    {
        public uint Id 
        { 
            get; set; 
        }
        public string Text
        {
            get;set;
        }
        public DateTime Data
        {
            get;set;
        }
        public string Name
        {
            get;set;
        }

        public Report(uint id, string text)
        {
            Id = id;
            Text = text;
            Data = DateTime.Now;
        }
    }

    public class DailyReport : IReport
    {
        public DateTime Data 
        { 
            get; set; 
        }
        public List<Task> tasks 
        { 
            get; set; 
        }
        public uint Id 
        { 
            get; set; 
        }
        public Worker employee
        {
            get;set;
        }
        public ReportStatus status
        {
            get;set;
        }
        public List<(Task, Changes)> history;
        public string Text 
        { 
            get; set; 
        }
        public string Name 
        { 
            get; set; 
        }

        public DailyReport(DateTime data, List<Task> tasks, uint id, Worker employee)
        {
            status = ReportStatus.Created;
            Data = data;
            this.tasks = tasks;
            Id = id;
            this.employee = employee;
            history = new List<(Task, Changes)>();

        }


        public DailyReport(Worker employee)
        {
            this.employee = employee;
        }
        
    }

    public class SprintReport : IReport
    {
        public DateTime Data 
        { 
            get; set; 
        }
        public List<Task> tasks 
        { 
            get; set; 
        }
        public uint Id 
        { 
            get; set; 
        }
        public ReportStatus status
        {
            get; set;
        }
        public Worker director
        {
            get;set;
        }
        public Worker employeers
        {
            get;set;
        }
        public string Text 
        { 
            get; set; 
        }
        public string Name 
        { 
            get; set; 
        }

        public SprintReport(DateTime data, List<Task> tasks, uint id, Worker director, Worker employeers)
        {
            status = ReportStatus.Created;
            Data = data;
            this.tasks = tasks;
            Id = id;
            this.director = director;
            this.employeers = employeers;

        }

        public SprintReport(Worker director, List<Worker> employeers)
        {
            this.director = director;
            this.employeers = new List<Worker>();
        }
        public void AddTask(Task t)
        {
            tasks.Add(t);
        }
        public void RemoveTask(Task t)
        {
            tasks.Remove(t);
        }

        public Task GetTasks(uint id)
        {
            return tasks.Find((task => task.Id == id));
        }

        public List<Task> GetAll()
        {
            return tasks;
        }

    }
}
