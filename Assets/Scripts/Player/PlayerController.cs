using System;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody PlayerRb;
    const int SPEED = 800;
  

    public event Action DamageAction;
    public event Action JumpAction;
    public event Action FinishAction;

    protected bool finish;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (finish) {return;}

        //前に進む処理
        if (Input.GetKey(KeyCode.W))
        {
            PlayerRb.AddForce(SPEED * transform.forward * Time.deltaTime);
        }
        //リスタートしたとき加えてた力もリセットする処理
        if(transform.position.z == -2)
        {
            PlayerRb.linearVelocity = Vector3.zero;
        }


        //ジャンプ
        if (transform.position.y >= 10.5f) { return; }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpAction?.Invoke();
            transform.position = transform.position + new Vector3(0, 1.5f, 0);
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Finish")
        {
            FinishAction?.Invoke();
            finish = true;
            PlayerRb.linearVelocity = Vector3.zero;
        }
    }

    //障害物に当たった時の処理
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacles")
        {
            Destroy(collision.gameObject);
            DamageAction?.Invoke();
        }
    }


}
