using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class fireScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform BulletTransform;
    GameObject bulletGo;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable=GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetMouseButtonUp(0)
        //OVRInput.Get(OVRInput.RawButton.RHandTrigger)

        
    }
    public void FireBullet(ActivateEventArgs arg)
    {
        bulletGo = GameObject.Instantiate(BulletPrefab);
        bulletGo.transform.position = BulletTransform.position;

        bulletGo.transform.rotation = transform.rotation;

        Rigidbody rigid = bulletGo.GetComponent<Rigidbody>();
        rigid.AddForce(transform.forward * 2000);
    }



}
