using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public int time = 5;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(BulletDestroyFunc), time);

    }
    void Update()
    {
        
    }
    void BulletDestroyFunc()
    {
        Destroy(gameObject);
    }
}
