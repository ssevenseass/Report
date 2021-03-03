using System;
using DAL;
using BLL;
using System.Collections.Generic;

namespace UI
{
    public class User
    {

        /*public List<ManagerEmployee> empl;
        public List<ManagerReports> rep;
        public List<ManagerTasks> tas;*/
    
        public ManagerEmployee controllerW;

    
        public ManagerReports controllerR;

    
        public ManagerTasks controllerT;


    
        public User(ManagerEmployee mE, ManagerReports mR, ManagerTasks mT)
   
        {
            controllerW = new ManagerEmployee(mE);

            controllerR = new ManagerReports(mR);

            controllerT = new ManagerTasks(mT);
    
        }

 
  }
        
}
