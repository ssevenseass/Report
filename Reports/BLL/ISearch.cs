using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ISearch
    {

        public uint Id
        {
            get; set;
        }
        public DateTime Data
        {
            get; set;
        }
        public DAL.Task Searching();
    }
}