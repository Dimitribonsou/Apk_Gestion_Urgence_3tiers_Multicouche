using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public  class ProblemeBLL
    {
       public int id { get; set; }
       public string libelle { get; set; }
       public string nomService { get; set; }
       public string nomPersonnel { get; set; }
       public string description { get; set; }
       public DateTime date { get; set; }
    }
}
