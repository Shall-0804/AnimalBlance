using UnityEngine;

public class WindEffectAudioController : WindEffectController
{
    [SerializeField] AudioSource WindAudio;
    
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z == -2)
        {
            WindAudio.Stop();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Wind")
        {
            if(WindTimesTouched == 0)
            {
                WindAudio.Play();
            }
            else
            {
                WindTimesTouched--;
                WindAudio.Stop();
            }
        }
    }
}
