using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomobj : MonoBehaviour
{
    public GameObject[] cube;  //����һ��cube�����Ҫ������ɵ�Ԥ����
    private float t1, t2;//ͨ��ʱ�������ƶ������һ��
    public Transform huBU;

    void Start()
    {
        t1 = 0;//��Ϸ��ʼ��ʱ��
    }
    void Update()
    {

        t2 = Time.fixedTime;//��Ϸ���е�ĳ��λ�õ�ʱ��
        if (t2 - t1 >= 2)//���t2-t1>=2�룬���������һ��
        {
            float x = Random.Range(-9, 9);//�涨x�᷽���ϵķ�Χ
            float y = Random.Range(-5, 5);//�涨z�᷽���ϵķ�Χ
                                          //�����Լ�������ʵ�����ȥ�涨��Χ
            GameObject obj = Instantiate(cube[Random.Range(0, cube.Length)], new Vector2(x, y), Quaternion.identity);//����������壨Ԥ���壬���ɵ�λ�ã����򣩡�
            obj.transform.SetParent(huBU);
            t1 = t2;//ÿ����һ�Σ���Ҫ��t1=t2
        }
    }
}
