using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateDown();
    }

    void RotateDown() {
	transform.Rotate(Vector3.right * Time.deltaTime * 30);
    }
}
