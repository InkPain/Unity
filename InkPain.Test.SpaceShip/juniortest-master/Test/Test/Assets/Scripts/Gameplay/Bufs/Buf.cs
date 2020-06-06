using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Buf : MonoBehaviour, IBufed
    {
        HPSystem healthSystem;

    private Gameplay.Weapons.Weapon gun;

        [SerializeField]
        private int _type;

        public int Typees => _type;


        private void Start()
        {
            healthSystem = GameObject.FindGameObjectWithTag("Player").GetComponent<HPSystem>();
            gun = GameObject.FindGameObjectWithTag("PlayerGun").GetComponent<Gameplay.Weapons.Weapon>();
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            ApplyBuf(_type);
            Destroy(gameObject);
        }
    }
        public void ApplyBuf(int type)
        {
            type = _type;

            if (type == 0 && healthSystem.health != 3)
            {
            healthSystem.health = +3;
            }
            else if( type == 1)
            {
            gun._cooldown = gun._cooldown / 1.025f;
            }
        }

    }

