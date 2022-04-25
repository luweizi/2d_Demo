using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Buttonevents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(Clickevent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Clickevent()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Start");
    }
}
