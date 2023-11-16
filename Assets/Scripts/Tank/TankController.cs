using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{

    private float tkSpeed = 12f;
    private float tkTurnSpeed = 180f;

    private void FixedUpdate()
    {
        float mv = Input.GetAxis("Vertical") * tkSpeed * Time.deltaTime;
        transform.Translate(0, 0, mv);
        float rotate = Input.GetAxis("Horizontal") * tkTurnSpeed * Time.deltaTime;
        transform.Rotate(0, rotate, 0);
    }
}
