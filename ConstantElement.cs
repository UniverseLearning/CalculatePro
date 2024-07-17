using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePro
{
    public class ConstantElement
    {

        public static string FilePath = "D:\\CalculatePro\\element.csv";
        public ConstantElement() { }

        public ConstantElement(int p1, string p2, string p3, decimal? p4, decimal? p5, decimal? p6)
        {
            Id = p1;
            Type = p2;
            Name = p3;
            Density = p4;
            Strength = p5;
            Thermal = p6;
        }


        public int Id { get; set; }// 主键ID

        public string Type { get; set; }// 种类

        public string Name { get; set; }// 名称

        public decimal? Density { get; set; }// 密度(Kg/m³)

        public decimal? Strength { get; set; }// 强度(Mp)

        public decimal? Thermal { get; set; }// 热导率 W/(m·k)


        public static List<ConstantElement> InitData()
        {
            List<ConstantElement> lists = new List<ConstantElement>();
            lists.Add(new ConstantElement(1, "钢", "1023碳钢板", 7858M, 282.6M, null));
            lists.Add(new ConstantElement(2, "钢", "AISI1020(20#)", 7900M, 351.5M, 47M));
            lists.Add(new ConstantElement(3, "钢", "AISI1045(45#)", 7850M, 530M, 49.8M));
            lists.Add(new ConstantElement(4, "钢", "AISI304", 8000M, 206.8M, 16M));
            lists.Add(new ConstantElement(5, "钢", "AISI316", 8000M, 172.3M, null));
            lists.Add(new ConstantElement(6, "钢", "合金钢", 7700M, 620.4M, null));
            lists.Add(new ConstantElement(7, "钢", "铸造碳钢", 7800M, 248.1M, 30M));
            lists.Add(new ConstantElement(8, "钢", "铸造不锈钢", 7700M, null, 37M));
            lists.Add(new ConstantElement(9, "钢", "镀铬不锈钢", 7800M, 172.3M, 18M));
            lists.Add(new ConstantElement(10, "钢", "电镀钢", 7870M, 203.9M, null));
            lists.Add(new ConstantElement(11, "钢", "普通碳钢", 7800M, 220.5M, 43M));
            lists.Add(new ConstantElement(12, "钢", "不锈钢铁素体", 7800M, 172.3M, 18M));

            lists.Add(new ConstantElement(13, "铁", "延性铁（球墨铸铁）", 7100M, 551.4M, 75M));
            lists.Add(new ConstantElement(14, "铁", "灰铸铁", 7200M, 572.1M, 45M));
            lists.Add(new ConstantElement(15, "铁", "可锻铸铁", 7300M, 275.4M, 47M));

            lists.Add(new ConstantElement(16, "铝合金", "1060合金（纯铝）", 2700M, 275.7M, 200M));
            lists.Add(new ConstantElement(17, "铝合金", "1060-H12", 2705M, 75M, 230M));
            lists.Add(new ConstantElement(18, "铝合金", "1060-H18", 2705M, 125M, 230M));
            lists.Add(new ConstantElement(19, "铝合金", "1345合金", 2700M, 27.57M, 220M));
            lists.Add(new ConstantElement(20, "铝合金", "1350合金", 2700M, 27.57M, 230M));
            lists.Add(new ConstantElement(21, "铝合金", "2014合金", 2800M, 96.5M, 160M));
            lists.Add(new ConstantElement(22, "铝合金", "2014-O", 2800M, 95M, 880M));
            lists.Add(new ConstantElement(23, "铝合金", "2014-T4", 2800M, 290M, 880M));
            lists.Add(new ConstantElement(24, "铝合金", "2014-T6", 2800M, 415M, 880M));
            lists.Add(new ConstantElement(25, "铝合金", "2018合金", 2800M, 317M, 1000M));
            lists.Add(new ConstantElement(26, "铝合金", "2024合金", 2800M, 75.8M, 800M));
            lists.Add(new ConstantElement(27, "铝合金", "2024-T3", 2780M, 345M, 875M));
            lists.Add(new ConstantElement(28, "铝合金", "2024-T361", 2780M, 395M, 875M));
            lists.Add(new ConstantElement(29, "铝合金", "2024-T4", 2780M, 325M, 875M));
            lists.Add(new ConstantElement(30, "铝合金", "2219-O", 2840M, 70M, 864M));
            lists.Add(new ConstantElement(31, "铝合金", "2219-T31", 2840M, 250M, 116M));
            lists.Add(new ConstantElement(32, "铝合金", "2219-T37", 2840M, 315M, 116M));
            lists.Add(new ConstantElement(33, "铝合金", "2219-T62", 2840M, 290M, 120M));
            lists.Add(new ConstantElement(34, "铝合金", "2219-T81", 2840M, 350M, 120M));
            lists.Add(new ConstantElement(35, "铝合金", "2219-T87", 2840M, 395M, 120M));
            lists.Add(new ConstantElement(36, "铝合金", "3003合金", 2700M, 41.3M, 170M));
            lists.Add(new ConstantElement(37, "铝合金", "3003-H12", 2730M, 125M, 162M));
            lists.Add(new ConstantElement(38, "铝合金", "3003-H14", 2730M, 145M, 159M));
            lists.Add(new ConstantElement(39, "铝合金", "3003-H18", 2730M, 185M, 155M));
            lists.Add(new ConstantElement(40, "铝合金", "3003-O", 2730M, 40M, 193M));
            lists.Add(new ConstantElement(41, "铝合金", "4032-T6", 2680M, 315M, 138M));
            lists.Add(new ConstantElement(42, "铝合金", "5052-H32", 2680M, 195M, 137M));
            lists.Add(new ConstantElement(43, "铝合金", "5052-H34", 2680M, 215M, 137M));
            lists.Add(new ConstantElement(44, "铝合金", "5052-H36", 2680M, 240M, 127M));
            lists.Add(new ConstantElement(45, "铝合金", "5052-H38", 2680M, 255M, 137M));
            lists.Add(new ConstantElement(46, "铝合金", "5052-O", 2680M, 90M, 137M));
            lists.Add(new ConstantElement(47, "铝合金", "5454-H111", 2690M, 180M, 134M));
            lists.Add(new ConstantElement(48, "铝合金", "5454-H112", 2690M, 125M, 134M));
            lists.Add(new ConstantElement(49, "铝合金", "5454-H32", 2690M, 205M, 134M));
            lists.Add(new ConstantElement(50, "铝合金", "5454-H34", 2690M, 240M, 134M));
            lists.Add(new ConstantElement(51, "铝合金", "5454-O", 2690M, 115M, 134M));
            lists.Add(new ConstantElement(52, "铝合金", "6061合金", 2700M, 55.1M, 170M));
            lists.Add(new ConstantElement(53, "铝合金", "6061-O", 2700M, 62M, null));
            lists.Add(new ConstantElement(54, "铝合金", "6063-O", 2700M, 218M, null));
            lists.Add(new ConstantElement(55, "铝合金", "6063-T1", 2700M, 90M, 193M));
            lists.Add(new ConstantElement(56, "铝合金", "6063-T4", 2700M, 90M, 209M));
            lists.Add(new ConstantElement(57, "铝合金", "6063-T5", 2700M, 145M, 209M));
            lists.Add(new ConstantElement(58, "铝合金", "6063-T6", 2700M, 240M, 209M));
            lists.Add(new ConstantElement(59, "铝合金", "6063-T83", 2700M, 240M, 201M));
            lists.Add(new ConstantElement(60, "铝合金", "7075-T73510", 2830M, 435M, 155M));
            lists.Add(new ConstantElement(61, "铝合金", "7075-T6(SN)", 2810M, 505M, 130M));
            lists.Add(new ConstantElement(62, "铝合金", "7079合金", 2700M, null, 120M));
            lists.Add(new ConstantElement(63, "铝合金", "氧化铝", 3960M, null, 30M));


            return lists;
        }
    }
}
