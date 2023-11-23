using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    public int playerNum = 1;
    public Rigidbody Shell;
    public Transform fireTransform;

    string fireKey;

    // Start is called before the first frame update
    void Start()
    {
        fireKey = "Fire" + playerNum;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(fireKey))
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
