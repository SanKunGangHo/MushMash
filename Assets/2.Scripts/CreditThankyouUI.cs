using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CreditThankyouUI : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject thankyou;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnVideoEnd(VideoPlayer vp)
    {
        thankyou.SetActive(true);
    }
}
