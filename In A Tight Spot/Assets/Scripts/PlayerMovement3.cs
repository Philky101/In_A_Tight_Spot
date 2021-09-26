using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3 : MonoBehaviour
{
    int partNum;
    int currentNum;
    int prevNum;

    // Start is called before the first frame update
    void Start()
    {
        partNum = 3;
        currentNum = 1;
        prevNum = -5;
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

        if (Input.GetKeyDown("e"))
        {
            if (currentNum == 3)
            {
                currentNum = 1;
                prevNum = 3;
            }
            else
            {
                currentNum += 1;
                if (prevNum == 3)
                {
                    prevNum = 1;
                }
                else
                {
                    prevNum += 1;
                }
            }
            if (prevNum <= 0)
            {
                prevNum = 1;
            }
            if (currentNum == partNum)
            {
                movement.y = (float)-50.8;
            }
            else if (prevNum == partNum)
            {
                movement.y += (float)50.8;
            }
        }

        transform.Translate(movement);
    }
}
