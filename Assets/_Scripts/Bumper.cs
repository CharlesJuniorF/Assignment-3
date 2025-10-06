using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float bumpForce = 1f;
    public int points = 100;

    private AudioSource audio;

    private void Start()
    {
        audio = GetComponentInChildren<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.CompareTag("PlayerBall"))
        {
            audio.Play();

            Vector3 myCenter = transform.position;
            Vector3 contantPoint = collision.GetContact(0).point;

            myCenter.y = contantPoint.y;
            Vector3 forceVector = contantPoint - myCenter;

            Rigidbody rb = collision.rigidbody;
            rb.AddForce(forceVector * bumpForce, ForceMode.Impulse);

            ScoreManager.AddScore(points);
        }
    }
}
