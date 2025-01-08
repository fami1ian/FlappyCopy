using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject LoseWindow;
    public static GameManager instance;

    private void Start()
    {
        instance = this;
    }

    public void Restart22Scene ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex) ;
        Time.timeScale = 1;
    }
    public void Lose ()
    {
        LoseWindow.SetActive(true); 
        Time.timeScale = 0;
    }
    public void LoadScene (int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber) ;
        Time.timeScale = 1;
    }
}
