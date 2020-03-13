using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCShapeDemo
{
    /// <summary>
    /// DateTime测试
    /// </summary>
    class DateTimeDemo
    {
        static void Main(string[] args)
        {
            //1.得到当前时间
            DateTime dateTime = DateTime.Now;
            //2. 默认ToString方法格式：2020/03/13 13:35:20
            Console.WriteLine($"{dateTime.ToString()}");
            //3.利用ToString()方法可传入格式格式类型：y、M、d、h、m、s、f
            Console.WriteLine($"{dateTime.ToString("yyyy-MM-dd hh:mm:ss:ff")}");
            //4.还可根据对照表去生成
            //https://www.cnblogs.com/sunbingqiang/p/10272814.html
            Console.WriteLine($"{dateTime.ToString("U")}");

            //5. 得到具体日期
            int year = dateTime.Year;
            int month = dateTime.Month;
            int day = dateTime.Day;
            string dayOfWeek = dateTime.DayOfWeek.ToString();
            int hour = dateTime.Hour;
            int minute = dateTime.Minute;
            int second = dateTime.Second;

            Console.WriteLine($"当前时间为：{year}年{month}月{day}日 {dayOfWeek} {hour}时{minute}分{second}秒");
            Console.ReadLine();
        }
    }
}
