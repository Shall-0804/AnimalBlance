using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody PlayerRb;
    const int SPEED = 800;
    const int JUMP = 500;
    

    protected bool finish;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (finish) {return;}

        //�O�ɐi�ޏ���
        if (Input.GetKey(KeyCode.W))
        {
            PlayerRb.AddForce(SPEED * transform.forward * Time.deltaTime);
        }
        //���X�^�[�g�����Ƃ������Ă��͂����Z�b�g���鏈��
        if(transform.position.z == -2)
        {
            PlayerRb.linearVelocity = Vector3.zero;
        }


        //�W�����v
        if (transform.position.y >= 10.5f) { return; }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = transform.position + new Vector3(0, 1.5f, 0);
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
