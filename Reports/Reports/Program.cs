using System;
using DAL;
using BLL;
using UI;
using System.Collections.Generic;

namespace Reports
{

    class Program

    {

        static void Main(string[] args)

        {

            ManagerEmployee emp1 = new ManagerEmployee();

            User cr = new User(new ManagerEmployee(), new ManagerReports(), new ManagerTasks());


            Worker worker1 = cr.controllerW.CreateEmployee(132, "Emp1");

            Worker worker2 = cr.controllerW.CreateEmployee(433, "Emp2");

            Worker worker3 = cr.controllerW.CreateEmployee(22, "Emp3");

            cr.controllerW.GetDirector(worker1, worker2);

            cr.controllerW.GetDirector(worker3, worker2);

            List<Worker> workers = new List<Worker>();
            workers.Add(worker1);
            workers.Add(worker3);

            Task task1 = cr.controllerT.CreateTask(1, "task1", "task 1", States.Active);

            Task task2 = cr.controllerT.CreateTask(44, "task2", "task 2", States.Open);

            Task task3 = cr.controllerT.CreateTask(34, "task3", "task 3", States.Resolved);

            Task task4 = cr.controllerT.CreateTask(56, "task4", "task 4", States.Active);

            cr.controllerT.AddComment(task1, "this is task 1");
            cr.controllerT.ChangeState(task2, States.Active);
            cr.controllerT.ChangeWorker(task1, worker1);

            cr.controllerR.Daily(worker1);
            cr.controllerR.Sprint(worker2, workers);



        }
    }
}