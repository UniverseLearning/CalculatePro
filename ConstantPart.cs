using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePro
{
    public class ConstantPart
    {
        public static string FilePath = "D:\\CalculatePro\\part.csv";
        public ConstantPart() { }

        public ConstantPart(int p1, string p2, decimal? p3)
        {
            Id = p1;
            Name = p2;
            PartCost = p3;
        }

        public int Id { get; set; }// 主键ID

        public string Name { get; set; }// 名称

        public decimal? PartCost { get; set; }// 采购件

        public static List<ConstantPart> InitData()
        {
            List<ConstantPart> lists = new List<ConstantPart>();
            lists.Add(new ConstantPart(1, "螺丝", 1M));
            lists.Add(new ConstantPart(2, "螺母", 1M));

            return lists;
        }
    }
}
