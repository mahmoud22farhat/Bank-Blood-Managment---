using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.Models
{
    class BloodBagModel
    {
     public   int id { get; set; }
        public string dname { get; set; }
        public string donerID { get; set; }
        public int techID { get; set; }
        public string startdate { get; set; }
        public string endtdate { get; set; }
        public int Bloodtype { get; set; }
        public string note { get; set; }
        public string statubag { get; set; }



    }
}
