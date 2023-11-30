using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    GameObject test_camera;

    // Start is called before the first frame update
    void Start()
    {
        test_camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = test_camera.transform.forward;
    }
}
