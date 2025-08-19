using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody PlayerRb;
    const int SPEED = 600;
    

    bool finish;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (finish) {return;}

        //ëOÇ…êiÇﬁèàóù
        if (Input.GetKey(KeyCode.W))
        {
            PlayerRb.AddForce(SPEED * transform.forward * Time.deltaTime);
        }
        
       

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Finish")
        {
            finish = true;  
            PlayerRb.linearVelocity = Vector3.zero;
        }
    }
}
