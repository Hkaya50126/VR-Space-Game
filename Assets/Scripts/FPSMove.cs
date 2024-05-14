using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : MonoBehaviour
{
    float speed = 10;
    float mouseSensivity = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(1))
        {
            float axisX = Input.GetAxis("Mouse X") * mouseSensivity;
            float axisY = Input.GetAxis("Mouse Y") * mouseSensivity;

            Quaternion q1 = transform.rotation;
            Vector3 rot1 = q1.eulerAngles;

            rot1.x -= axisY;
            rot1.y += axisX;

            Quaternion q = Quaternion.Euler(rot1);
            transform.rotation = q;


            float internalSpeed = speed * Time.deltaTime;



            Vector3 pos = transform.position;

            if (Input.GetKey(KeyCode.W))
            {
                pos = pos + (q * Vector3.forward * internalSpeed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                pos = pos - (q * Vector3.forward * internalSpeed);
            }

            if (Input.GetKey(KeyCode.D))
            {
                pos = pos + (q * Vector3.right * internalSpeed);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                pos = pos - (q * Vector3.right * internalSpeed);
            }

            if (Input.GetKey(KeyCode.E))
            {
                pos = pos + (q * Vector3.up * internalSpeed);
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                pos = pos - (q * Vector3.up * internalSpeed);

            }

            transform.position = pos;
        }

    }
}
