using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtomController : MonoBehaviour
{
    public void OnClick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
