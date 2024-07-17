using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePro
{
    public class ConstantCheck
    {
        public static string FilePath = "D:\\CalculatePro\\check.csv";
        public ConstantCheck() { }

        public ConstantCheck(int p1, string p2, decimal? p3)
        {
            Id = p1;
            Name = p2;
            CheckCost = p3;
        }

        public int Id { get; set; }// 主键ID

        public string Name { get; set; }// 名称

        public decimal? CheckCost { get; set; }// 检查费


        public static List<ConstantCheck> InitData()
        {
            List<ConstantCheck> lists = new List<ConstantCheck>();
            lists.Add(new ConstantCheck(1, "外观检验", 8M));
            lists.Add(new ConstantCheck(2, "尺寸检验", 10M));
            lists.Add(new ConstantCheck(3, "耐压检验", 15M));
            lists.Add(new ConstantCheck(4, "螺纹检验", 40M));
            lists.Add(new ConstantCheck(5, "电性能检验", 10M));

            return lists;
        }
    }
}
