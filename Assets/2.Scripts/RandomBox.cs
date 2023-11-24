using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomBox : MonoBehaviour
{
    private Vector3 spawnPoint;
    public GameObject spawnObject, explosive;
    public AudioSource questionBox;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fist"))
        {
            Instantiate(spawnObject, spawnPoint, spawnObject.gameObject.transform.rotation);
            Instantiate(explosive, spawnPoint, spawnObject.gameObject.transform.rotation);
            questionBox.GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
        }
    }
}
