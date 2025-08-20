using TMPro;
using UnityEngine;

public class FinishUIController : PlayerController
{
    [SerializeField] GameObject FinishText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (finish)
        {
            FinishText.SetActive(true);
        }
    }
}
