using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGain : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject coinRing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            coinRing.GetComponent<AudioSource>().Play();
            gameObject.SetActive(false);
            gameManager.CoinGet();
        }
    }
}
