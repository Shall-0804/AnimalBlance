using UnityEngine;

public class OptionBackButtomController : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    public void Onclick()
    {
        Panel.SetActive(false);
    }
}
