using UnityEngine;

public class PlayerJumpAudioController : MonoBehaviour
{
    [SerializeField] AudioSource JumpAudio;
    [SerializeField] PlayerController playerController;
    private void Start()
    {
        playerController.JumpAction += Jump;
    }
    // Update is called once per frame
    void Update()
    {
    }
    void Jump()
    {
        JumpAudio.Play();
    }
}
