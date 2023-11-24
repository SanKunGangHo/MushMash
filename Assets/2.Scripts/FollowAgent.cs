using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowAgent : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject player;
    public Animator anim;
    public float radius_;

    public Collider[] hitCollider;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        overlaped();
    }

    public void ChasingPlayer()
    {
        anim.SetBool("Walk", true);
        agent.destination = player.transform.position;
    }

    public void overlaped()
    {
        hitCollider = Physics.OverlapSphere(transform.position, radius_);
       for(int i=0; i < hitCollider.Length; i++) {
            if(hitCollider[i].gameObject == player)
            {
                ChasingPlayer();
            }
        }
    }
}
