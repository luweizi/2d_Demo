using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventmanagement
{
    private static Eventmanagement instance;
    public static Eventmanagement Instance
    {
        get
        {
            if (null == instance)
                instance = new Eventmanagement();
            return instance;
        }
    }

    public delegate void Money(int count);//注册金币数量事件
    private event Money Display;

    public void Added_coin(Money incident)//添加更新金币事件
    {
        Display += incident;
    }

    public void Perform_coin(int count)//执行更新金币事件
    {
        if (Display != null)
        {
            Display(count);
        }
    }
}
