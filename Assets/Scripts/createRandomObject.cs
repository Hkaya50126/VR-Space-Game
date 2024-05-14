using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class createRandomObject : MonoBehaviour
{
    public GameObject PrefabObject;
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => CreateSphere());

    }
    public void CreateSphere()
    {
        Rigidbody rigid = PrefabObject.GetComponent<Rigidbody>();

        float x, y, z;
        for (int i = 0; i < 20; i++)
        {
            //x = Random.Range(20.5f, 29.5f);
            //y = Random.Range(0.5f, 3.5f);
            //z = Random.Range(-54.5f, -62.5f);

            x = Random.Range(24.29f, 24.35f);
            y = Random.Range(1.21f, 1.25f);
            z = Random.Range(-58.33f, -58.38f);

            GameObject createdObject = GameObject.Instantiate(PrefabObject);
            createdObject.transform.position = new Vector3(x, y, z);

            createdObject.transform.SetParent(parent.transform);

            //GetComponentInChildren
            MeshRenderer mr = createdObject.GetComponent<MeshRenderer>();
            Material mat = mr.material;
            mat.color = Random.ColorHSV();
            rigid.AddForce(Random.Range(0, 5f) * 500, Random.Range(0, 5f) * 500, Random.Range(0, 5f) * 500);

        }
    }

}
