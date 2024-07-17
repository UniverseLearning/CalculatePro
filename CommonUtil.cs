using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatePro
{
    public class CommonUtil
    {
        /// <summary>
        /// 判断输入数字是否合理
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool CheckDigitFormat(TextBox tb, KeyPressEventArgs e)
        {
            bool flag = false;
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar) && e.KeyChar != 46)
            {
                flag = true;

            }
            // 小数点的处理
            if (e.KeyChar == 46)
            {
                if (tb.Text.Length <= 0)
                    flag = true;   //小数点不能在第一位
                else
                {
                    // 判断是否是正确的小数格式
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(tb.Text, out oldf);
                    b2 = float.TryParse(tb.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            flag = true;
                        else
                            flag = false;
                    }
                }
            }
            return flag;
        }

        public static T ConvertToType<T>(object value)
        {
            try
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch (InvalidCastException)
            {
                // 转换失败的处理
                Console.WriteLine($"Conversion to {typeof(T).Name} failed.");
                return default(T); // 或者抛出异常，具体情况可以根据需求来处理
            }
        }


        public static object ConvertToType(object value, Type targetType)
        {
            try
            {
                return Convert.ChangeType(value, targetType);
            }
            catch (InvalidCastException)
            {
                // 转换失败的处理
                Console.WriteLine($"Conversion to {targetType.Name} failed.");
                return targetType.IsValueType ? Activator.CreateInstance(targetType) : null;
                // 或者抛出异常，具体情况可以根据需求来处理
            }
        }
    }
}
