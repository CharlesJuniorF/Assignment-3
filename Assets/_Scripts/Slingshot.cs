using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    public float bumpForce = 1f;
    public int points = 175;

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
            Rigidbody rb = collision.rigidbody;
            rb.AddForce(transform.forward * bumpForce, ForceMode.Impulse);
            ScoreManager.AddScore(points);

        }
    }
}
