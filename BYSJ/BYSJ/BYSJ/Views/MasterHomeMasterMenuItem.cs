using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYSJ
{

    public class MasterHomeMasterMenuItem
    {
        public MasterHomeMasterMenuItem()
        {
            TargetType = typeof(MasterHomeMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}