using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        int speed = 25;

        Vector3 pos = transform.position;

        Vector3 movement = new Vector3(speed * inputX, 0, 0);
        movement *= Time.deltaTime;

        if (pos.x >= 9.5 && inputX >= 0)
        {
            movement.x = 0;
        }
        else if (pos.x <= -9.5 && inputX <= 0)
        {
            movement.x = 0;
        }

        transform.Translate(movement);
    }
}
