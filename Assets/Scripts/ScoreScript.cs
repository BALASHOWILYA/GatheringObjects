using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ScoreScript : MonoBehaviour
{

    [SerializeField] private TMP_Text scoreText;
    private int scoreNum;

    void Start()
    {
        scoreNum = 0;
        scoreText.text = "Score: " + scoreNum;
    }

    private void OnTriggerEnter2D(Collider2D circle)
    {
        if (circle.CompareTag("Obstacle"))
        {
            scoreNum++;
            Destroy(circle.gameObject);
            scoreText.text = "Score: " + scoreNum;
            if (scoreNum == 5) SceneManager.LoadScene(1); 
        }
    }

}
