using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageController : PlayerStatusController 
{
    [SerializeField]PlayerController playerController;
    public event Action ReGenarate;
    public event Action Death;

    void Start()
    {
        playerController.DamageAction += AddDamage;
    }
    void Update()
    {
    }

    void AddDamage()
    {
        Hp--;
        if (Hp > 0)
        {
            Debug.Log("�_���[�W���󂯂�" + Hp);
        }
        else�@if (Hp <= 0)
        {
            Debug.Log("����" + Hp);
            DeathHp--;
            if (DeathHp < 0)
            {
                SceneManager.LoadScene("Death");
            }
            Death?.Invoke();
            ReGenarate?.Invoke();
            
        }

        AddHPBer();

    }
}
