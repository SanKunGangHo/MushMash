using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirePunched : MonoBehaviour
{
    public float damageAmount = 10f;
    private bool isCoroutineRunning = false;

    public void OnCollisionEnter(Collision collision)
    {
        if(!isCoroutineRunning && collision.gameObject.CompareTag("Fist"))
        {
            StartCoroutine(Burn());
        }
    }

    IEnumerator Burn()
    {
        isCoroutineRunning = true; 
        while (UserData._FireUp)
        {
            yield return new WaitForSeconds(1f);
            this.GetComponent<MonsterHP>().mon_HP -= 5;
            //피격 음성
        }
        isCoroutineRunning = false;
    }
}
