using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BYSJ.Models
{
    public class Engineer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public workshop Workshop { get; set; }
        public group Group { get; set; }

        public override string ToString()
        {
            return $"ID：{ID}， 姓名：{Name}，车间：{Workshop}，工厂：{Group}";
        }

        public enum workshop
        {
            TC3B1,
            TC3B2,
            TC3B,
            PQ
        }

        public enum group
        {
            TC3B
        }
    }
}
