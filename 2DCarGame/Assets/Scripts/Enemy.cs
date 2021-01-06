using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] float health = 500f;

    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        DamageDealer dmgDealer = otherObject.gameObject.GetComponent<DamageDealer>();

        health -= dmgDealer.GetDamage();

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
