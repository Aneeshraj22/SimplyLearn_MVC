using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalLib;

namespace BalLib
{
    public class Classdata
    {
        public int Classid
        {
            get;
            set;
        }
        public int Studentid
        {
            get;
            set;
        }
        public int subjectid
        {
            get;
            set;
        }
    }


    public class Studentdata
    {
        public int Studentid
        {
            get;
            set;
        }
        public string Studentname
        {
            get;
            set;
        }
        public int Studentage
        {
            get;
            set;
        }
    }
    public class Subjectdata
    {
        public int subjectid
        {
            get;
            set;
        }
        public string subjectname
        {
            get;
            set;
        }
       
    }
   
}
