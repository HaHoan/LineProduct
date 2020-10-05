using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Production
{

    public class ObjReport
    {
        public string _no { get; set; }
        public string _macBox { get; set; }
        public string _id { get; set; }

        public ObjReport(string no, string macBox, string id)
        {
            _no = no;
            _macBox = macBox;
            _id = id;
        }
    }
}
