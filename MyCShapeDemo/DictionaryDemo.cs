using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCShapeDemo
{
    //测试字典类型
    class DictionaryDemo
    {
        //创建一个Dictionary
        static Dictionary<string, string> openWith = new Dictionary<string, string>();
        //main
        //static void Main(string[] args)
        //{
        //    #region 1.插入
        //    //使用Add方法向Dictionary中插入值
        //    openWith.Add("txt", "notepad.exe");
        //    openWith.Add("bmp", "paint.exe");
        //    openWith.Add("dib", "paint.exe");
        //    openWith.Add("rtf", "wordpad.exe");

        //    try
        //    {
        //        openWith.Add("rtf", "wordpad2.exe");
        //    }
        //    catch (ArgumentException)
        //    {
        //        //如果插入相同的key，则会报ArgumentException错误，value相同是可以的
        //        Console.WriteLine("An element with Key = \"txt\" already exists.");
        //    }

        //    //插入之前应该先用ContainsKey方法判断是否有值
        //    if (!openWith.ContainsKey("containsKey"))
        //    {
        //        openWith.Add("containsKey", "containsKey.exe");
        //        Console.WriteLine("Value added for key = \"containsKey\": {0}",
        //            openWith["containsKey"]);
        //    }
        //    #endregion

        //    #region 2.读取
        //    //通过key，使用索引直接读取value
        //    Console.WriteLine("For key =\"rft\",value={0},", openWith["rtf"]);

        //    //如果key不存在，则会抛
        //    try
        //    {
        //        Console.WriteLine("For key =\"notfoundkey\",value={0},", openWith["notfoundkey"]);
        //    }
        //    catch (KeyNotFoundException)
        //    {
        //        Console.WriteLine("Key = \"notfoundkey\" is not found.");
        //    }

        //    //使用TryGetValue把获取到的值，赋值给变量
        //    string value = "";
        //    if (openWith.TryGetValue("rtf", out value))
        //    {
        //        Console.WriteLine("For key = \"defaultKey\", value = {0}.", value);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Key = \"defaultKey\" is not found.");
        //    }


        //    //使用键值对KeyValuePair来遍历
        //    foreach (KeyValuePair<string, string> kvp in openWith)
        //    {
        //        Console.WriteLine("Key = {0}, Value = {1}",kvp.Key, kvp.Value);
        //    }

        //    //使用Values属性得到单独的value
        //    Dictionary<string, string>.ValueCollection valuecoll = openWith.Values;
        //    foreach (string val in valuecoll)
        //    {
        //        Console.WriteLine("Value = {0}", val);
        //    }

        //    //使用Keys属性得到单独的keys
        //    Dictionary<string, string>.KeyCollection keyColl = openWith.Keys;
        //    foreach (string key in keyColl)
        //    {
        //        Console.WriteLine("Key = {0}", key);
        //    }

        //    #endregion

        //    #region 3.修改
        //    //通过key,使用索引直接给其赋值
        //    openWith["rtf"] = "update wordpad.exe";
        //    Console.WriteLine("For key =\"rft\",value={0},", openWith["rtf"]);

        //    //如果key不存在，则会增加key，并赋值
        //    openWith["addkey"] = "addkey.exe";
        //    Console.WriteLine("For key =\"addkey\",value={0},", openWith["addkey"]);
        //    #endregion


        //    #region 4.删除
        //    //使用Remove方法，通过key移除
        //    openWith.Add("removeKey", "removeValue");
        //    Console.WriteLine("For key =\"removeKey\",value={0},", openWith["removeKey"]);
        //    openWith.Remove("removeKey");
        //    if (!openWith.ContainsKey("removeKey"))
        //    {
        //        Console.WriteLine("For key =\"removeKey\",is not found.");
        //    }
            

        //    #endregion
        //    Console.ReadLine();
        //}
    }
}
