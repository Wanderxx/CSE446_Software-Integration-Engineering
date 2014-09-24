using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、服务和配置文件中的类名“Service”。
public class Service : IService
{
    public string GetData(int value)
    {
        return string.Format("You entered: {0}", value);
    }
    public string SecretNumber(string lower, string upper)
    {
        DateTime currentDate = DateTime.Now;
        int seed = (int)currentDate.Ticks;
        Random random = new Random(seed);
        Int32 lo = Convert.ToInt32(lower);
        Int32 up = Convert.ToInt32(upper);
        int Number = random.Next(lo, up);
        string sNumber = Number.ToString();
        return sNumber;
    }
    public string checkNumber(string userNum, string SecretNum)
    {
        Int32 lo = Convert.ToInt32(userNum);
        Int32 up = Convert.ToInt32(SecretNum);
        if (lo == up)
            return "correct";
        else
            if (lo > up)
                return "too big";
            else return "too small";
    }

}
