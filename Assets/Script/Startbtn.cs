using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Startbtn : MonoBehaviour
{
    public GameObject Btn;
    // Start is called before the first frame update
    void Start()
    {
        Button button = Btn.GetComponent<Button>();
        button.onClick.AddListener(btn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void btn()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
}
