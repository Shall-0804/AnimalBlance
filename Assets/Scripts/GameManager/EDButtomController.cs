using UnityEngine;
using UnityEngine.SceneManagement;

public class EDButtomController : MonoBehaviour
{
    public void OnClick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
