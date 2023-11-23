using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public int playerNum = 1;


    private string mvAxis;
    private string rotAxis;
    private float tkSpeed = 12f;
    private float tkTurnSpeed = 180f;

    private void Start()
    {
        mvAxis = "Vertical" + playerNum;
        rotAxis = "Horizontal" + playerNum;
    }

    private void FixedUpdate()
    {
        float mv = Input.GetAxis(mvAxis) * tkSpeed * Time.deltaTime;
        transform.Translate(0, 0, mv);
        float rotate = Input.GetAxis(rotAxis) * tkTurnSpeed * Time.deltaTime;
        transform.Rotate(0, rotate, 0);

        if (transform.position.y <= -3)
        {
            Destroy(gameObject);
        }
    }
}
