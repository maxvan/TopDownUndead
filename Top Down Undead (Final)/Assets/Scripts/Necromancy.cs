﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Necromancy : MonoBehaviour
{
    public GameObject prefab;
    public float shootSpeed = 1.0f;
    public float shootDelay = 2.5f;
    float timer = 0;
    public Transform player;
    public float shootTriggerDistance = 10.0f;
    void Update()
    {
        timer += Time.deltaTime;
        Vector2 shootDirection = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        if (timer > shootDelay && shootDirection.magnitude < shootTriggerDistance)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            shootDirection.Normalize();
            bullet.GetComponent<Chase>().player = player;
            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * shootSpeed;
        }
    }
}
