using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            myRigidbody.velocity = Vector2.up * 8;
        }
        if (Input.GetKey(KeyCode.A))
        {
            myRigidbody.velocity = Vector2.left * 4;
        }
        if (Input.GetKey(KeyCode.D))
        {
            myRigidbody.velocity = Vector2.right * 4;
        }
    }
}
