using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BYSJ.Models.Engineer;

namespace BYSJ.Models
{
    public class repairRecord
    {
        public string orderNumber { get; set; }         //维修单号
        public DateTime maintainTime { get; set; }      //维护日期
        public group Group { get; set; }                //工厂
        public workshop Workshop { get; set; }          //车间
        public string Area { get; set; }                //区域
        public string Station { get; set; }             //工位
        public failureMode FailureMode { get; set; }    //故障类型
        public string FailureDetail { get; set; }       //故障内容
        public string RepairMeasures { get; set; }      //修理措施
        public string LongtimeMeasures { get; set; }    //长期措施
        public int MaintanenceTime { get; set; }        //故障修理时间
        public string RepairPeople { get; set; }        //维修责任人
        public string MaintanencePeople { get; set; }   //保养责任人
        public int ShutdownTime { get; set; }           //影响主线时间
        public string writtenby { get; set; }           //填写人
        public DateTime writtenTime { get; set; }       //填写时间 
        public string SVWNumber { get; set; }           //SVW物料号
        public int SparePartNo { get; set; }            //备件消耗数量
        public int ReworkNo { get; set; }               //返修件消耗数量
        public bool isFinished { get; set; }            //故障单完成情况
        public string remark { get; set; }              //备注

        public override string ToString()
        {
            return $"序号：{orderNumber} \n " +
                $"维护日期：{SVWNumber}\n" +
                $"工厂：{Group}\n " +
                $"车间:{Workshop}\n" +
                $"区域:{Area}\n" +
                $"工位:{Station}\n" +
                $"故障类型:{FailureMode}\n" +
                $"故障内容:{FailureDetail}\n" +
                $"修理措施:{RepairMeasures}\n" +
                $"长期措施:{LongtimeMeasures}\n" +
                $"故障修理时间:{MaintanenceTime}\n" +
                $"维修责任人:{RepairPeople}\n" +
                $"保养责任人:{MaintanencePeople}\n" +
                $"影响主线时间:{ShutdownTime}\n" +
                $"填写人:{writtenby}\n" +
                $"填写时间:{writtenTime}\n" +
                $"SVW物料号:{SVWNumber}\n" +
                $"备件消耗数量:{SparePartNo}\n" +
                $"返修件消耗数量:{ReworkNo}\n" +
                $"故障单完成情况:{isFinished}\n" +
                $"备注:{remark}\n";
        }
    }



    public enum failureMode
    {
        PLC故障,
        传输系统故障,
        其它,
        切割设备,
        夹具故障,
        定位设备,
        机器人故障,
        机械断裂,
        涂胶设备,
        激光设备故障,
        焊接设备
    }
}
