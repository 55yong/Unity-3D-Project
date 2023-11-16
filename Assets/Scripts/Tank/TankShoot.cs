using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    public Rigidbody Shell;
    public Transform fireTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire"))
        {
            Fire();
        }
    }

    void Fire()
    {
        Rigidbody shellInstance = Instantiate(Shell, fireTransform.position, fireTransform.rotation);

        shellInstance.velocity = 20.0f * fireTransform.forward;
    }
}
