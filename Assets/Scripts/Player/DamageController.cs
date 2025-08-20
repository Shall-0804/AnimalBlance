using System;
using UnityEngine;

public class DamageController : PlayerStatusController 
{
    [SerializeField]PlayerController playerController;
    public event Action ReGenarate;

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
            ReGenarate?.Invoke();
            
        }

        AddHPBer();

    }
}
