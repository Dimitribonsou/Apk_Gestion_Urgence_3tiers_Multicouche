using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public  class ProgrammeBLL
    {
       public int id { get; set; }
       public string libelle { get; set; }
       public DateTime date_debut { get; set; }
       public DateTime date_fin { get; set; }
       public string description { get; set; }
       public string service { get; set; }

    }
}
