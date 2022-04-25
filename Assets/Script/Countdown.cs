using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Countdown : MonoBehaviour
{
    private Text text;
    int TotalTime = 120;
    public GameObject Gameover;
    public GameObject btn;
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<Text>();
        StartCoroutine(CountDown());

    }

    IEnumerator CountDown()
    {
        while (TotalTime >= 0)
        {
            text.GetComponent<Text>().text = TotalTime.ToString();
            yield return new WaitForSeconds(1);
            TotalTime--;
            if (TotalTime == 0)
            {
                Gameover.SetActive(true);
                btn.SetActive(true);
            }


        }

    }
}
