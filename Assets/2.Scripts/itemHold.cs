using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemHold : MonoBehaviour
{
    public Image hand;
    public GameObject Q_UI;
    public GameObject Mush;
    public GameObject Flower;
    public GameObject Fire;
    public bool isMush = false, isFlower = false;

    public void MushroomAte()
    {
        isMush = true;
        if (isFlower)
        {
            isFlower = false;
            Flower.SetActive(false);
        }
        Q_UI.SetActive(true);
        Mush.SetActive(true);
    }

    public void FlowerAte()
    {
        isFlower = true;
        if (isMush)
        {
            isMush= false;
            Mush.SetActive(false);
        }
        Q_UI.SetActive(true);
        Flower.SetActive(true);
    }

    public void MushroomUsed()
    {
        isMush = false;
        Q_UI.SetActive(false);
        Mush.SetActive(false);
        hand.color = new Color32(120,55,109,255);
    }

    public void FlowerUsed()
    {
        isFlower = false;
        Q_UI.SetActive(false);
        Flower.SetActive(false);
        Fire.SetActive(true);
        hand.color = new Color32(255, 79, 0, 255);
    }
}
