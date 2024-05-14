using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleWall : MonoBehaviour
{
    Collider cl;
    // Start is called before the first frame update
    void Start()
    {
        cl= gameObject.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Bullet"))
        {
            cl.isTrigger = true;
        }
        else
        {
            cl.isTrigger = false;
        }
    }
}
