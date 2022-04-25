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

    public delegate void Money(int count);//ע���������¼�
    private event Money Display;

    public void Added_coin(Money incident)//��Ӹ��½���¼�
    {
        Display += incident;
    }

    public void Perform_coin(int count)//ִ�и��½���¼�
    {
        if (Display != null)
        {
            Display(count);
        }
    }
}
