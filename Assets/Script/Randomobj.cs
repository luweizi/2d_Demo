using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomobj : MonoBehaviour
{
    public GameObject[] cube;  //定义一个cube来存放要随机生成的预制体
    private float t1, t2;//通过时间来控制多久生成一次
    public Transform huBU;

    void Start()
    {
        t1 = 0;//游戏开始的时间
    }
    void Update()
    {

        t2 = Time.fixedTime;//游戏进行到某个位置的时间
        if (t2 - t1 >= 2)//如果t2-t1>=2秒，就随机生成一个
        {
            float x = Random.Range(-9, 9);//规定x轴方向上的范围
            float y = Random.Range(-5, 5);//规定z轴方向上的范围
                                          //根据自己场景的实际情况去规定范围
            GameObject obj = Instantiate(cube[Random.Range(0, cube.Length)], new Vector2(x, y), Quaternion.identity);//随机生成物体（预制体，生成的位置，方向）。
            obj.transform.SetParent(huBU);
            t1 = t2;//每生成一次，就要让t1=t2
        }
    }
}
