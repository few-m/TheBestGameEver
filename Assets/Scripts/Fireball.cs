﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyFireball", lifetime);
    }

    private void FixedUpdate()
    {
        MoveFixedUpdate();
    }
    private void OnCollisionEnter(Collision collision)
    {
        DamageEnemy(collision);
        DestroyFireball();
    }
    private void DamageEnemy(Collision collision)
    {
        var enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.DealDamage(damage);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void MoveFixedUpdate()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    private void DestroyFireball()
    {
        Destroy(gameObject);
    }
}
