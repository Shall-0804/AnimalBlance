using UnityEngine;
using UnityEngine.UI;

public class PlayerStatusController : MonoBehaviour
{
    [SerializeField] Slider HPBer;
    protected int Hp = 10;

    Vector3 originalPlayerPos;
    void Start()
    {
       originalPlayerPos = transform.position;
    }
    void Update()
    {       
    }
    protected void AddHPBer()
    {
        HPBer.value = Hp;
        if( Hp <= 0 )
        {
            Hp = 10;
            transform.eulerAngles = Vector3.zero;
            transform.position = originalPlayerPos;
            AddHPBer();
        }
    }

}
