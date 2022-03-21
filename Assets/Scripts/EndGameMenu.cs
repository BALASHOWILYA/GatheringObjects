
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour
{

    public void BackToGame(string loadNameScene)
    {
        SceneManager.LoadScene(loadNameScene);
    }
    
}
