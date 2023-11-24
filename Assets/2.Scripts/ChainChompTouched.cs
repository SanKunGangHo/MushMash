using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainChompTouched : MonoBehaviour
{
    GameObject player;
  
    void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Player")){
            player = other.gameObject;
            player.GetComponent<PlayerMove>().damaged(5);
        }
    }
}
