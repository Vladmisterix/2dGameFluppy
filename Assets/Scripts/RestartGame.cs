using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
    public void restartGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
