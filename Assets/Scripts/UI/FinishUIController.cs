using TMPro;
using UnityEngine;

public class FinishUIController : MonoBehaviour
{
    [SerializeField] GameObject FinishText;
    [SerializeField] PlayerController playerController;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerController.FinishAction += FinishTextActive;
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FinishTextActive()
    {
        FinishText.SetActive(true);
    }
}
