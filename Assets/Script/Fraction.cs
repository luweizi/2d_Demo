using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fraction : MonoBehaviour
{
    public Text text;
    private int currentnumber;
    public GameObject Tips;
    public GameObject btn;
    // Start is called before the first frame update
    void Start()
    {
        text = text.GetComponent<Text>();
        Eventmanagement.Instance.Added_coin(this.Renewal);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentnumber >= 20)
        {
            Tips.SetActive(true);
            btn.SetActive(true);
        }
    }
    public void Renewal(int number)
    {
        currentnumber += number;
        text.text = string.Format("Score:{0}", currentnumber);
    }
}
