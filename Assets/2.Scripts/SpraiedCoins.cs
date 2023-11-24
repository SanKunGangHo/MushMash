using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class SpraiedCoins : MonoBehaviour
{
    // Update is called once per frame
    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce(Vector3.forward);
        Invoke("destroyCoin", 2f);
    }

    private void Update()
    {
        
    }

    void destroyCoin()
    {
        Destroy(gameObject);
    }
}
