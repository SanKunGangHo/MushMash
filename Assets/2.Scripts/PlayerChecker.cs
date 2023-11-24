using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChecker : MonoBehaviour
{
    public itemHold _itemHold;
    public AudioSource itemDrop;
    public SceneManager_ sceneManager_;
    public GameObject animCam;
    public Animator starAnim;
    public AnimEnd animEnd;

    // Start is called before the first frame update
    void Start()
    {
        _itemHold = GameObject.Find("Items").GetComponent<itemHold>();
        itemDrop = GameObject.Find("MusicRecorder").transform.GetChild(3).GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            itemDrop.Play();
            if (this.gameObject.CompareTag("Mushroom"))
            {
                if (!_itemHold.isMush) 
                {
                    _itemHold.MushroomAte();
                }
                else
                {
                    UserData.Coins += 20;
                }
                Destroy(this.gameObject);
            }

            if (this.gameObject.CompareTag("Flower"))
            {
                if (!_itemHold.isFlower)
                {
                    _itemHold.FlowerAte();
                }
                else
                {
                    UserData.Coins += 30;
                }
                Destroy(this.gameObject);
            }
        }

        if (other.gameObject.CompareTag("Fist"))
        {
            if (this.gameObject.CompareTag("Star"))
            {
                animCam.SetActive(true);
                animEnd.enabled = true; 
                starAnim.SetBool("isEnd", true);
                GameManager.instance.GameEnd = true;
            }
        }
    }
}
