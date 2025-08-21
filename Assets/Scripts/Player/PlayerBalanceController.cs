using UnityEngine;
using UnityEngine.UIElements;

public class PlayerBalanceController : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //â°Ç…à⁄ìÆ
        //ç∂
        if (Input.GetKey(KeyCode.A))
        {
           transform.Rotate(0, 0, 1f);
        }
        //âE
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -1f);
        }
    }
}
