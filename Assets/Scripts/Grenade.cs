﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float damage = 50;

    public float delay = 3;
    public GameObject explosionPrefab;
    private void OnCollisionEnter(Collision collision)
    {
        Invoke("Explosion", delay);
    }
    private void Explosion()
    {
        Destroy(gameObject);
        var explosion = Instantiate(explosionPrefab);
        explosion.transform.position = transform.position;
        explosion.GetComponent<Explosion>().damage = damage;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
