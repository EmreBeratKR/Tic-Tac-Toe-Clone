using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void resetGame()
    {
        SceneManager.LoadScene(0);
    }
}
