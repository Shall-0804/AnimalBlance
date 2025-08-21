using UnityEngine;

public class WindEffectController : MonoBehaviour
{
    protected int WindTimesTouched = 0;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z == -2)
        {
            WindTimesTouched = 0;
        }

        if (WindTimesTouched >= 1)
        {
            transform.Rotate(0, 0, 0.05f);
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wind")
        {
            if (WindTimesTouched == 0)
            {
                WindTimesTouched++;
            }
            else
            {
                WindTimesTouched--;
            }
        }
    }
}
