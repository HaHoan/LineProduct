using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Production.Entities
{
    public class HondaLock
    {
        public int ID { get; set; }
        public string ProductionID { get; set; }
        public string BoxID { get; set; }
        public string BoardNo { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string Update_Code { get; set; }
        public string Update_Name { get; set; }

    }
}
