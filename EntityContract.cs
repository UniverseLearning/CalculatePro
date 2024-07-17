using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CalculatePro
{
    /// <summary>
    /// 合同类
    /// </summary>
    public class EntityContract
    {
        public static string FilePath = "D:\\CalculatePro\\contract.csv";
        public EntityContract() { }

        public EntityContract(int p1, string p2, string p3, string p4, string p5, decimal? p6, decimal? p7, decimal? p8)
        {
            Id = p1;
            ContractNo = p2;
            ContractName = p3;
            ClientName = p4;
            ClientPhone = p5;
            LogisticsCost = p6;
            OtherCost = p7;
            TotalCost = p8;
        }


        public int Id { get; set; }// 主键ID

        public string ContractNo { get; set; }// 合同号

        public string ContractName { get; set; }// 合同名称

        public string ClientName { get; set; }// 客户名称

        public string ClientPhone { get; set; }// 联系电话

        public decimal? LogisticsCost { get; set; }// 物流费用

        public decimal? OtherCost { get; set; }// 其它费用

        public decimal? TotalCost { get; set; }// 总费用

        public static List<EntityContract> InitData()
        {
            List<EntityContract> lists = new List<EntityContract>();
            return lists;
        }

        /// <summary>
        /// 读取数据集合
        /// </summary>
        public static List<EntityContract> ReadData()
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
            }
            List<EntityContract> entities = new List<EntityContract>();
            using (var reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    EntityContract entity = new EntityContract();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        entity.Id = Convert.ToInt32(fields[0]);
                        entity.ContractNo = fields[1];
                        entity.ContractName = fields[2];
                        entity.ClientName = fields[3];
                        entity.ClientPhone = fields[4];
                        entity.LogisticsCost = Convert.ToDecimal(fields[5]);
                        entity.OtherCost = Convert.ToDecimal(fields[6]);
                        entity.TotalCost = Convert.ToDecimal(fields[7]);
                    }
                    entities.Add(entity);
                }
            }
            return entities;
        }

        /// <summary>
        /// 通过ID读取数据
        /// </summary>
        public static EntityContract ReadData(int Id)
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
            }
            EntityContract entity = new EntityContract();
            using (var reader = new StreamReader(FilePath))
            {
                string line;
                bool flag = true;
                while ((line = reader.ReadLine()) != null && flag)
                {
                    string[] fields = line.Split(',');
                    for (int i = 0; i < fields.Length; i++)
                    {
                        entity.Id = Convert.ToInt32(fields[0]);
                        entity.ContractNo = fields[1];
                        entity.ContractName = fields[2];
                        entity.ClientName = fields[3];
                        entity.ClientPhone = fields[4];
                        entity.LogisticsCost = Convert.ToDecimal(fields[5]);
                        entity.OtherCost = Convert.ToDecimal(fields[6]);
                        entity.TotalCost = Convert.ToDecimal(fields[7]);
                        if (Id == entity.Id) { flag = false; }
                    }
                }
            }
            return entity;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        public static EntityContract UpdateData(EntityContract entity)
        {
            // 目标ID
            Int32 targetId = entity.Id;

            // 读取全部数据
            List<EntityContract> entities = ReadData();
            if (entities != null && entities.Count > 0)
            {
                entities = entities.Where(p => p.Id != targetId).ToList();
                entities.Add(entity);
                entities = entities.OrderBy(p => p.Id).ToList();
                // 清空CSV
                CSVUtil.ClearCSV(FilePath);
            }
            using (FileStream fs = new FileStream(FilePath.Trim(), FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    for (int i = 0; i < entities.Count; i++)//<--row
                    {
                        sw.WriteLine(entities[i].Id + "," +
                            entities[i].ContractNo + "," +
                            entities[i].ContractName + "," +
                            entities[i].ClientName + "," +
                            entities[i].ClientPhone + "," +
                            entities[i].LogisticsCost + "," +
                            entities[i].OtherCost + "," +
                            entities[i].TotalCost);
                    }
                    fs.Flush();
                }
            }
            return entity;
        }
    }
}
