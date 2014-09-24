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
    public int SecretNumber(int lower, int upper)
    {
        DateTime currentDate = DateTime.Now;
        int seed = (int)currentDate.Ticks;
        Random random = new Random(seed);
        int sNumber = random.Next(lower, upper);
        return sNumber;
    }
    public string checkNumber(int userNum, int SecretNum)
    {
        if (userNum == SecretNum)
            return "correct";
        else
            if (userNum > SecretNum)
                return "too big";
            else return "too small";
    }
	
}
