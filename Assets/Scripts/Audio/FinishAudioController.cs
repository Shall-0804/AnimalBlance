using UnityEngine;

public class FinishAudioController : MonoBehaviour
{
    [SerializeField] AudioSource FinishAudio;
    [SerializeField] PlayerController playerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerController.FinishAction += FinishAudioPlay;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void FinishAudioPlay()
    {
        FinishAudio.Play();
    }
}
