using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public int playerNum = 1;
    public ParticleSystem targetExplosion;

    private float health = 1.0f;
    private string hpName;

    private void Start()
    {
        hpName = "HP" + playerNum; 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "SHELL")
        {
            health -= 0.5f;
            GameObject.Find(hpName).GetComponent<HPController>().HPControl(health);

            if (health <= 0f)
            {
                ParticleSystem fire = Instantiate(targetExplosion, transform.position, Quaternion.identity);

                fire.Play();

                Destroy(gameObject);
                Destroy(fire, 2.0f);
            }
        }
    }
}
