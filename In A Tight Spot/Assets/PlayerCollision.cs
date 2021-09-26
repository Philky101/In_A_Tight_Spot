using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //bool isColliding = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //isColliding = true;
           
                Debug.Log("Got Hit");
          
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        {
            /*if (transform.rotation.eulerAngles.x >= 170 && transform.rotation.eulerAngles.x <= 190)
            {
                //Debug.Log("It's 180");
            }*/
        }
    }

    /*void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("got hit");
        }
    }*/



}
