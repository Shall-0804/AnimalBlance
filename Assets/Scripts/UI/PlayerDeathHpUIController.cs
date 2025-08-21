using UnityEngine;

public class PlayerDeathHpUIController : PlayerStatusController
{
    [SerializeField]DamageController damageController;
    [SerializeField] GameObject DeathHp1;
    [SerializeField] GameObject DeathHp2;
    [SerializeField] GameObject DeathHp3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        damageController.Death += DeathHpDown;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DeathHpDown()
    {
        DeathHp--;
        Debug.Log(DeathHp);
        DeathHp1.SetActive(false);
        if(DeathHp == 1)
        {
            DeathHp2.SetActive(false);
        }
        else if(DeathHp == 0)
        {
            DeathHp3.SetActive(false);
        }
    }
}
