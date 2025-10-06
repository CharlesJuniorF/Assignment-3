using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    private GameManager manager;
    private AudioSource audio;

    private void Start()
    {
        manager = FindObjectOfType<GameManager>();
        audio = GetComponentInChildren<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("PlayerBall"))
        {
            //destroy the ball
            Destroy(other.gameObject);

            //Play death sound
            audio.Play();

            //tell the game that the ball was destroyed
            manager.Endball();
        }
    }
}
