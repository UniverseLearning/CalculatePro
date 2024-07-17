using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePro
{
    public class CSVUtil
    {


        /// <summary>
        /// 清空CSV
        /// </summary>
        public static void ClearCSV(string FilePath)
        {
            // 确保文件存在
            if (File.Exists(FilePath))
            {
                FileStream srm = File.Open(FilePath, FileMode.OpenOrCreate, FileAccess.Write);
                srm.Seek(0, SeekOrigin.Begin);
                srm.SetLength(0); //清空文件
                srm.Close();
            }
        }

        /// <summary>
        /// 获取最大ID
        /// </summary>
        public static Int32 MaxId(string FilePath)
        {

            Int32 max = 1;
            // 使用using语句确保StreamReader资源正确释放
            using (var reader = new StreamReader(FilePath))
            {
                string line;
                // 循环读取文件中的每一行
                while ((line = reader.ReadLine()) != null)
                {
                    // 使用Split函数按逗号分隔行内容
                    string[] fields = line.Split(',');

                    // 这里可以对分隔后的字段数据进行处理或存储
                    // 示例：打印每一行的字段
                    for (int i = 0; i < fields.Length; i++)
                    {
                        if (Convert.ToInt32(fields[0]) > max)
                        {
                            max = Convert.ToInt32(fields[0]);
                        }
                    }
                }
            }
            return max;
        }


































    }
}
