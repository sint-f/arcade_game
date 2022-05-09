using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFlip : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }

       if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

       if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }

       if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }
    }
}
