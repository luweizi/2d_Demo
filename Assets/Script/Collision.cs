using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("!!!!!!!!!!");
        if (collision.tag == "shiwu")
        {
            GameObject.Destroy(this.gameObject);
            Eventmanagement.Instance.Perform_coin(1);
        }
    }
}
