using UnityEngine;
using UnityEngine.SceneManagement;

public class OpButtomController : MonoBehaviour
{
    public void OnClick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
