using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePro
{
    public class ConstantInterface
    {
        public static string FilePath = "D:\\CalculatePro\\interface.csv";
        public ConstantInterface() { }

        public ConstantInterface(int p1, string p2, decimal? p3)
        {
            Id = p1;
            Name = p2;
            FaceCost = p3;
        }

        public int Id { get; set; }// 主键ID

        public string Name { get; set; }// 名称

        public decimal? FaceCost { get; set; }// 表面处理费


        public static List<ConstantInterface> InitData()
        {
            List<ConstantInterface> lists = new List<ConstantInterface>();
            lists.Add(new ConstantInterface(1, "喷砂", 80M));
            lists.Add(new ConstantInterface(2, "拉丝", 100M));
            lists.Add(new ConstantInterface(3, "抛光", 150M));
            lists.Add(new ConstantInterface(4, "喷漆", 400M));
            lists.Add(new ConstantInterface(5, "喷塑", 100M));
            lists.Add(new ConstantInterface(6, "氧化-阳极氧化", 100M));
            lists.Add(new ConstantInterface(7, "氧化-导电黄", 100M));
            lists.Add(new ConstantInterface(8, "氧化-氧化黑", 100M));
            lists.Add(new ConstantInterface(9, "氧化-电镀", 200M));
            lists.Add(new ConstantInterface(10, "钝化", 200M));
            lists.Add(new ConstantInterface(11, "丝印-印版费", 200M));
            lists.Add(new ConstantInterface(12, "丝印-人工费", 200M));

            return lists;
        }
    }
}
