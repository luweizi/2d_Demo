using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private float speed = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if(transform.GetComponent<RectTransform>().anchoredPosition3D.y< 160)
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime, Space.World);
            }
           
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.GetComponent<RectTransform>().anchoredPosition3D.y  > -160)
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime, Space.World);
            }
           
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.GetComponent<RectTransform>().anchoredPosition3D.x > -300)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime, Space.World);
            }
                
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.GetComponent<RectTransform>().anchoredPosition3D.x < 300)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime, Space.World);
            }
              
        }
    }
    
}
