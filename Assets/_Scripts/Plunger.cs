using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{
    public float launchforce = 1f;
    public float fullForceDuation = 0.8f;
    public Rigidbody rb;

    private float secondsHold = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            secondsHold += Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            float timePct = secondsHold / fullForceDuation;
            if (timePct > 10 )
            {
                timePct = 1;
            }

            if (launchforce > 75)
            {
                launchforce = 75;
            }

            if (rb != null)
            {
                rb.AddForce(transform.up * launchforce * timePct);
                secondsHold = 0;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("PlayerBall"))
        {
            rb = collision.rigidbody;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        rb = null;
    }
}
