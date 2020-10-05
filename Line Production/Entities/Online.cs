using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Production.Entities
{

    public  class Online
    {
      
        public string LineID { get; set; }
        
        public string ModelID { get; set; }
        public int Plan { get; set; }
        public int Actual { get; set; }
        public DateTime? _Date { get; set; }
    }
}
