using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePro
{
    public class ConstantProcess
    {
        public static string FilePath = "D:\\CalculatePro\\process.csv";
        public ConstantProcess() { }


        public ConstantProcess(int p1, string p2, decimal? p3)
        {
            Id = p1;
            Name = p2;
            HourCost = p3;
        }

        public int Id { get; set; }// 主键ID

        public string Name { get; set; }// 名称

        public decimal? HourCost { get; set; }// 工时费


        public static List<ConstantProcess> InitData()
        {
            List<ConstantProcess> lists = new List<ConstantProcess>();
            lists.Add(new ConstantProcess(1, "车", 80M));
            lists.Add(new ConstantProcess(2, "铣床-三轴", 100M));
            lists.Add(new ConstantProcess(3, "铣床-四轴", 150M));
            lists.Add(new ConstantProcess(4, "铣床-五轴", 400M));
            lists.Add(new ConstantProcess(5, "刨床", 100M));
            lists.Add(new ConstantProcess(6, "磨床", 100M));
            lists.Add(new ConstantProcess(7, "钳-钻孔", 100M));
            lists.Add(new ConstantProcess(8, "钳-攻丝", 100M));
            lists.Add(new ConstantProcess(9, "钣金-激光切割", 200M));
            lists.Add(new ConstantProcess(10, "钣金-折弯", 200M));
            lists.Add(new ConstantProcess(11, "钣金-焊接", 200M));
            lists.Add(new ConstantProcess(12, "钣金-铆接", 200M));
            lists.Add(new ConstantProcess(13, "线切割", 60M));
            lists.Add(new ConstantProcess(14, "慢走丝", 0M));
            lists.Add(new ConstantProcess(15, "电火花", 0M));
            lists.Add(new ConstantProcess(16, "组装", 60M));

            return lists;
        }
    }
}
