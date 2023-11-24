using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemUse : MonoBehaviour
{
    public ParticleSystem[] levelUpParticle = new ParticleSystem[2];
    public ParticleSystem[] fireUpParticle = new ParticleSystem[2];
    public AudioSource level, fire;

    public itemHold _itemHold;

    void Start()
    {
        Transform levelup = GameObject.FindGameObjectWithTag("LevelUP").transform;
        levelUpParticle[0] = levelup.GetChild(0).GetComponent<ParticleSystem>();
        levelUpParticle[1] = levelup.GetChild(1).GetComponent<ParticleSystem>();
        level = levelup.GetChild(0).GetComponent<AudioSource>();

        Transform fireup = GameObject.FindGameObjectWithTag("FireUP").transform;
        fireUpParticle[0] = fireup.GetChild(0).GetComponent<ParticleSystem>();
        fireUpParticle[1] = fireup.GetChild(1).GetComponent<ParticleSystem>();
        fire = fireUpParticle[0].GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(_itemHold.isMush || _itemHold.isFlower)
            {
                itemChecker();
            }
        }
    }

    void itemChecker()
    {
        if (_itemHold.isMush)
        {
            MushParticleStart();
            level.Play();
            _itemHold.isMush = false;
        }
        if (_itemHold.isFlower)
        {
            FlowerParticleStart();
            fire.Play();    
            _itemHold.isFlower = false;
        }
    }

    void MushParticleStart()
    {
        for (int i = 0; i < levelUpParticle.Length; i++)
        {
            levelUpParticle[i].Play();
        }
        UserData._LevelUp = true;
        _itemHold.MushroomUsed();
    }

    void FlowerParticleStart()
    {
        for(int i = 0;i < fireUpParticle.Length; i++)
        {
            fireUpParticle[i].Play();
        }
        UserData._FireUp = true;
        _itemHold.FlowerUsed();
    }
}
