using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ManagerReports
    {
        public uint Id
        {
            get; set;
        }
        public DateTime Time
        {
            get; set;
        }
        public string Comment
        {
            get; set;
        }
        public Worker employee
        {
            get; set;
        }
        public ManagerReports managerReports
        {
            get; set;
        }
        public ManagerReports time
        {
            get; set;
        }
        public ManagerReports(ManagerReports managerReports)
        {
            this.managerReports = managerReports;
        }

        public ManagerReports()
        {
        }

        public DailyReport Daily(Worker employee)
        {
            return new DailyReport(employee);
        }

        public SprintReport Sprint(Worker director, List<Worker> employeers)
        {
            return new SprintReport(director, employeers);
        }

        public DailyReport FindReport(Worker empl)
        {
            return time.FindReport(empl);
        }


    }
}