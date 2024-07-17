using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePro
{
    /// <summary>
    /// 部件类
    /// </summary>
    public class EntityMateriel
    {
        public static string FilePath = "D:\\CalculatePro\\materiel.csv";
        public EntityMateriel() { }

        public EntityMateriel(int p1, int p2, string p3, string p4, int p5, decimal? p6, decimal? p7, decimal? p8, decimal? p9, decimal? p10, decimal? p11)
        {
            Id = p1;
            ContractId = p2;
            MaterialNo = p3;
            MaterialName = p4;
            Count = p5;
            ElementCost = p6;
            ProcessCost = p7;
            InterfaceCost = p8;
            CheckCost = p9;
            PartCost = p10;
            SubTotalCost = p11;

        }

        public int Id { get; set; }// 主键ID

        public int ContractId { get; set; }// 合同主键ID

        public string MaterialNo { get; set; }// 图号

        public string MaterialName { get; set; }// 部件名称

        public int Count { get; set; }// 数量

        public decimal? ElementCost { get; set; }// 材料费用

        public decimal? ProcessCost { get; set; }// 加工费用

        public decimal? InterfaceCost { get; set; }// 表面处理费用

        public decimal? CheckCost { get; set; }// 检验费用

        public decimal? PartCost { get; set; }// 采购件费用

        public decimal? SubTotalCost { get; set; }// 小计费用

        public static List<EntityMateriel> InitData()
        {
            List<EntityMateriel> lists = new List<EntityMateriel>();
            return lists;
        }

        /// <summary>
        /// 读取数据集合
        /// </summary>
        public static List<EntityMateriel> ReadData()
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
            }
            List<EntityMateriel> entities = new List<EntityMateriel>();
            using (var reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    EntityMateriel entity = new EntityMateriel();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        entity.Id = Convert.ToInt32(fields[0]);
                        entity.ContractId = Convert.ToInt32(fields[1]);
                        entity.MaterialNo = fields[2];
                        entity.MaterialName = fields[3];
                        entity.Count = Convert.ToInt32(fields[4]);
                        entity.ElementCost = Convert.ToDecimal(fields[5]);
                        entity.ProcessCost = Convert.ToDecimal(fields[6]);
                        entity.InterfaceCost = Convert.ToDecimal(fields[7]);
                        entity.CheckCost = Convert.ToDecimal(fields[8]);
                        entity.PartCost = Convert.ToDecimal(fields[9]);
                        entity.SubTotalCost = Convert.ToDecimal(fields[10]);
                    }
                    entities.Add(entity);
                }
            }
            return entities;
        }

        /// <summary>
        /// 通过ID读取数据
        /// </summary>
        public static EntityMateriel ReadData(int Id)
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
            }
            EntityMateriel entity = new EntityMateriel();
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
                        entity.ContractId = Convert.ToInt32(fields[1]);
                        entity.MaterialNo = fields[2];
                        entity.MaterialName = fields[3];
                        entity.Count = Convert.ToInt32(fields[4]);
                        entity.ElementCost = Convert.ToDecimal(fields[5]);
                        entity.ProcessCost = Convert.ToDecimal(fields[6]);
                        entity.InterfaceCost = Convert.ToDecimal(fields[7]);
                        entity.CheckCost = Convert.ToDecimal(fields[8]);
                        entity.PartCost = Convert.ToDecimal(fields[9]);
                        entity.SubTotalCost = Convert.ToDecimal(fields[10]);
                        if (Id == entity.Id) { flag = false; }
                    }
                    
                }
            }
            return entity;
        }

        /// <summary>
        /// 通过合同ID读取数据
        /// </summary>
        public static List<EntityMateriel> ReadDataByContractId(int contractId)
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
            }
            List<EntityMateriel> entities = new List<EntityMateriel>();
            using (var reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    EntityMateriel entity = new EntityMateriel();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        entity.Id = Convert.ToInt32(fields[0]);
                        entity.ContractId = Convert.ToInt32(fields[1]);
                        entity.MaterialNo = fields[2];
                        entity.MaterialName = fields[3];
                        entity.Count = Convert.ToInt32(fields[4]);
                        entity.ElementCost = Convert.ToDecimal(fields[5]);
                        entity.ProcessCost = Convert.ToDecimal(fields[6]);
                        entity.InterfaceCost = Convert.ToDecimal(fields[7]);
                        entity.CheckCost = Convert.ToDecimal(fields[8]);
                        entity.PartCost = Convert.ToDecimal(fields[9]);
                        entity.SubTotalCost = Convert.ToDecimal(fields[10]);
                    }
                    if (contractId == entity.ContractId)
                    {
                        entities.Add(entity);
                    }
                }
            }
            return entities;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        public static EntityMateriel UpdateData(EntityMateriel entity)
        {
            // 目标ID
            Int32 targetId = entity.Id;

            // 读取全部数据
            List<EntityMateriel> entities = ReadData();
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
                            entities[i].ContractId + "," +
                            entities[i].MaterialNo + "," +
                            entities[i].MaterialName + "," +
                            entities[i].Count + "," +
                            entities[i].ElementCost + "," +
                            entities[i].ProcessCost + "," +
                            entities[i].InterfaceCost + "," +
                            entities[i].CheckCost + "," +
                            entities[i].PartCost + "," +
                            entities[i].SubTotalCost);
                    }
                    fs.Flush();
                }
            }
            return entity;
        }
    }
}
