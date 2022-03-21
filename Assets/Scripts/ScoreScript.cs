using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private AudioSource collectionSoundEffect;
    
    private int _scoreNum;
    private short _maxScore = 5;


    private void OnTriggerEnter2D(Collider2D circle)
    {
        if (circle.CompareTag("Obstacle"))
        {
            collectionSoundEffect.Play();
            _scoreNum++;
            Destroy(circle.gameObject);
            scoreText.text = "Score: " + _scoreNum;
            if (_scoreNum == _maxScore)
            {
                
                SceneManager.LoadScene(1);
               
            }
                
        }
    }

}
