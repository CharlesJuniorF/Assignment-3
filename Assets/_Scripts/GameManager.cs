using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives = 3;
    public GameObject ballPreFab;
    public Transform ballStart;
    public GameObject gameOverPanel;

    private void Start()
    {
        gameOverPanel.SetActive(false);
    }

    public void Endball()
    {
        lives--;

        if (lives == 0)
        {
            //show game over
            gameOverPanel.SetActive(true);
        }
        else
        {
            //instantiate a new ball at the proper position
            Instantiate(ballPreFab, ballStart.position, Quaternion.identity);
        }

    }
}
