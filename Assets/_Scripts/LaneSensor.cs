using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneSensor : MonoBehaviour
{
    public int points = 30;

    private AudioSource audio;

    private void Start()
    {
        audio = GetComponentInChildren<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("PlayerBall"))
        {
            audio.Play();
            ScoreManager.AddScore(points);
        }
    }
}
