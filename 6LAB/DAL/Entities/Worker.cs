using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Worker : IEntity
    {
        private Worker worker;

        public string Name
        {
            get;set;
        }

        public Worker director
        {
            get;set;
        }
        public List<Worker> dependents
        {
            get;set;
        }
        public uint Id
        {
            get;set;
        }

      
        public Worker(string name, Worker director, List<Worker> dependents)
        {
            Name = name;
            this.director = director;
            this.dependents = dependents;
        }
        public Worker(string name)
        {
            Name = name;
        }

        public static implicit operator Worker(List<Worker> v)
        {
            throw new NotImplementedException();
        }
        ~Worker()
        {

        }
        public Worker(uint id, string name)
        {
            Id = id;
            Name = name;
        }

        public Worker(Worker worker)
        {
            this.worker = worker;
        }
    }
}
