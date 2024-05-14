using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploSphere : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            for (int i = 0; i < 20; i++)
            {
                Destroy(gameObject);
            }
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Bullet"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
