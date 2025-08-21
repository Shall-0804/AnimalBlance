using UnityEngine;

public class OptionButtomController : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    public void Onclick()
    {
        Panel.SetActive(true);
    }
}
