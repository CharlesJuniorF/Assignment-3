using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScripts : MonoBehaviour
{
    public int points = 50;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("PlayerBall"))
        {
            ScoreManager.AddScore(points);
            gameObject.SetActive(false);
        }
    }
}
