using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public string Count;
    public bool GameEnd = false;

    public TextMeshProUGUI tmp;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public void CoinGet(){
        UserData.Coins++;
        CoinCheck();
    }

    public void CoinLose()
    {
        UserData.Coins--;
        CoinCheck();
    }

    private void CoinCheck(){
        if (UserData.Coins < 10)
        {
            Count = "0" + UserData.Coins;
        }
        else
        {
            Count = "" + UserData.Coins;
        }
        tmp.text = Count;
    }
}
