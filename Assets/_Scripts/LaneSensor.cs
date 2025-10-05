using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneSensor : MonoBehaviour
{
    public int points = 30;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("PlayerBall"))
        {
            ScoreManager.AddScore(points);
        }
    }
}
