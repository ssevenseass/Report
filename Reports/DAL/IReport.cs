using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IReport
    {
        public uint Id
        {
            get;set;
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
    }
}
