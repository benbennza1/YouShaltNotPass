﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VioletGhost_Movement : Monster
{
    public GameObject target;
    private PlayerHealthController playerHealthController;
    public int Health = 20;
    public int PlayerDamage = 20;
    public float speed = 25f;

    // Use this for initialization
    void Start()
    {
        InitializeRotation();
        playerHealthController = FindObjectOfType<PlayerHealthController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += transform.forward * speed * Time.deltaTime;

        //Destroys monster once it reaches player for memory management purposes
        if (transform.localPosition.z < target.transform.position.z - 2)
        {
            // Damage the player.
            playerHealthController.TakeDamage(PlayerDamage);
            // Destroy the monster.
            Destroy(this.gameObject);
        }
    }
}
