using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ManEaterLookAt : MonoBehaviour
{
    public GameObject player;
    public float radius_;
    public bool PlayerChecked = false;

    public Collider[] hitCollider;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        overlaped();
    }

    void overlaped()
    {
        hitCollider = Physics.OverlapSphere(transform.position, radius_);
        for(int i = 0; i<hitCollider.Length; i++)
        {
            if (hitCollider[i].gameObject == player)
            {
                this.transform.LookAt(player.gameObject.transform, Vector3.up);
                PlayerChecked = true;
            }
        }
    }

}
