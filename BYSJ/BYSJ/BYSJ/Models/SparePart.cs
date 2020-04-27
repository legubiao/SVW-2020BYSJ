using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYSJ.Models
{
    public class SparePart
    {
        public string SVWNumber { get; set; }                   //SVW备件号
        public string DCNumber { get; set; }                    //DC备件号
        public DateTime CreatDate { get; set; }                 //物料生成日期
        public string Description { get; set; }                 //中/英文描述/规格型
        public string PartProducer { get; set; }                //备件制造商
        public string DeviceProducer { get; set; }              //设备制造商
        public string MachineNumber { get; set; }               //机器号
        public string MapNumber { get; set; }                   //图号
        public partUnit CountUnit { get; set; }                 //计量单位
        public ABCnumber ABCNumber { get; set; }                //ABC码
        public string PlannerNumber { get; set; }               //计划员码
        public int MinSafetyStock { get; set; }                 //最小安全库存
        public int MaxSafetyStock { get; set; }                 //最大安全库存
        public double price { get; set; }                       //价格
        public int OrderCycle { get; set; }                     //采购周期
        public string PartProperty { get; set; }                //物料属性
        public bool IsSafety { get; set; }                      //物料安全标识
        public producingArea ProducingArea { get; set; }        //产地


        public override string ToString()
        {
            return $"物料生成日期：{CreatDate} \n " +
                $"SVW备件号：{SVWNumber}\n" +
                $"DC备件号：{DCNumber}\n " +
                $"中/英文描述/规格型:{Description}\n"+
                $"设备制造商:{DeviceProducer}\n"+
                $"备件制造商:{PartProducer}\n"+
                $"机器号:{MachineNumber}\n"+
                $"图号:{MapNumber}\n" +
                $"计量单位:{CountUnit}\n" +
                $"ABC码:{ABCNumber}\n" +
                $"计划员码:{PlannerNumber}\n" +
                $"最小安全库存:{MinSafetyStock}\n" +
                $"最大安全库存:{MaxSafetyStock}\n" +
                $"采购周期:{OrderCycle}\n" +
                $"物料属性:{PartProperty}\n" +
                $"物料安全标识:{IsSafety}\n" +
                $"产地:{ProducingArea}\n";
        }

        public enum ABCnumber
        {
            A,
            B,
            C,
            D,

        }
        public enum partUnit
        {
            PU, PC, BOT, ML, EA, TON, CAN, PAC, SET, M2, TO, L, G, CAR, BAG, DMR, CAS, PR, rol, KG, PD, CTN, M, GP
        }
        
        public enum partStatus
        {
            常,
            重点,
            E,
            锁定,
            停产,
            富余,
            呆滞
        }
        public enum partProperty
        {
            撑钩撑棒类,
            国产定制备件,
            防护类,
            枪嘴类,
            吊具夹具类,
            机件,
            塑件类,
            擦拭类,
            电极类,
            包胶轮类,
            工装类,
            机加工件
        }
        public enum producingArea
        {
            国内,
            国际
        }
    }
}
