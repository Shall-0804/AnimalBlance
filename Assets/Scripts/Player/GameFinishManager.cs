using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinishManager : MonoBehaviour
{
    Vector3 originalPlayerPos;
    float time = 0f;
    const float TIME_NUM = 2f;
    private void Start()
    {
        originalPlayerPos = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        //ゲームオーバーの処理
        if (transform.position.y <= 9.5f)
        {
            transform.eulerAngles = Vector3.zero;
            transform.position = originalPlayerPos;
        }



        //ゲームクリアの処理
        if(time > 0)
        {
            time -= Time.deltaTime;
        }
        else if(time < 0)
        {
            SceneManager.LoadScene("ED");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            time = TIME_NUM;
        }
    }
}
