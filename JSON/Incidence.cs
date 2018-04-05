using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.JSON
{
    public class Incidence
    {
        public string _id {get; set;}
        public string mac {get; set;}
        public string userId {get; set;}
        public string title {get; set;}
        public string date {get; set;}
        public int category {get; set;}
        public string lat {get; set;}
        public string lng {get; set;}
        public int status {get; set;}
        public string street {get; set;}
        public string imageName {get; set;}
        public string streetbyUser {get; set;}
        public string resolutionDate { get; set; }
        public string email { get; set; }
    }
}
