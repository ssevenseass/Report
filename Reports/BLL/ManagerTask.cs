using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ManagerTasks
    {
        public List<Task> tasks;
        public ManagerTasks managerTasks
        {
            get; set;
        }
        public uint Id
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
        public List<(Worker, Task)> pairs;

        public ManagerTasks(ManagerTasks mT)
        {
            this.managerTasks = new ManagerTasks();
        }

        public ManagerTasks()
        {
        }

        public Task AddTask(uint id, string name, Worker employee, string comment)
        {
            return new Task(id, name, employee, comment);
        }

        public Task CreateTask(uint id, string name, string comment, States state)
        {
            return new Task(name, id, comment, state);
        }

        public void ChangeWorker(Task task, Worker worker)
        {
            task.employee = worker;
        }
        public void AddComment(Task task, string text)
        {
            task.Comment = text;
        }
        public void ChangeState(Task task, States state)
        {
            task.stateTask = state;
        }


        public List<Task> FindTask(List<(Worker, Task)> pairs, Worker director)
        {
            foreach (var w in director.dependents)
            {
                foreach (var pair in pairs)
                {
                    if (w == pair.Item1)
                    {
                        tasks.Add(pair.Item2);
                    }
                }
            }
            return tasks;
        }
        public ISearch SearchTaskByDate(DateTime data, SearchByDate search)
        {
            return new SearchByDate(data, tasks);
        }

        public ISearch SearchTaskByEmployee(SearchByEmployee search, Worker worker)
        {
            return new SearchByEmployee(tasks, worker);
        }

        public ISearch SearchTaskById(SearchById search, uint id)
        {
            return new SearchById(tasks, id);
        }
        public ISearch SearchTaskByChanges(SearchByChanges search, DateTime up)
        {
            return new SearchByChanges(tasks, up);
        }



    }
}