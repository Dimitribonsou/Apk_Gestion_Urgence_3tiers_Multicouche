using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public  class InformationBLL
    {
       public int id { get; set; }
       public string titre { get; set; }
       public string message { get; set; }
       public DateTime date_envoie { get; set; }
       public DateTime date_expiration { get; set; }
      public  string nomService { get; set; }
    }
}
