using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mist.Models
{
    public class Sportsman
    {
        public int ID { get; set; }
        public string NameID { get; set; }
        public int Birth { get; set; }
        public string Type1 { get; set; }
        public int Res1 { get; set; }
        public int Best1 { get; set; }
        public string Type2 { get; set; }
        public double Res2 { get; set; }
        public double Best2 { get; set; }
        public string Type3 { get; set; }
        public double Res3 { get; set; }
        public double Best3 { get; set; }
        public string Type4 { get; set; }
        public double Res4 { get; set; }
        public double Best4 { get; set; }
    }
}