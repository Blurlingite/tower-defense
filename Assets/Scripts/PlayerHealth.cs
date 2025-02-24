﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] int health = 10;
    [SerializeField] int healthDecrease = 1;
    [SerializeField] Text healthText;
    [SerializeField] AudioClip playerDamageSFX;
    [SerializeField] ParticleSystem explosionPrefab;



    void Start()
    {
        healthText.text = health.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().PlayOneShot(playerDamageSFX);

        health -= healthDecrease;
        healthText.text = health.ToString();
    }


    public int getPlayerHealth()
    {
        return health;
    }


}
