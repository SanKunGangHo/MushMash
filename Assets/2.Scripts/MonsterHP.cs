using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonsterHP : MonoBehaviour
{
    public int mon_HP;
    public int Damage = 5;
    public ParticleSystem particle;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        if(mon_HP <= 0)
        {
            particle.Play();
            particle.gameObject.GetComponent<AudioSource>().Play();
            mon_HP = 100;
            if(gameObject.CompareTag("Flower")){
                Destroy(transform.parent.gameObject);
            }else{
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Fist"))
        {
            Damaged();
        }
    }

    void Damaged()
    {
        if(UserData._LevelUp == true)
        {
            mon_HP -= Damage*2;
        }
        else
        {
            mon_HP -= Damage;
        }
    }
}
