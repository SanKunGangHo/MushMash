using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CreditThankyouUI : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public SceneManager_ scene;
    public GameObject thankyou;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
        thankyou.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnVideoEnd(VideoPlayer vp)
    {
        thankyou.SetActive(true);
        Invoke("SceneChanger", 2f);
    }

    private void SceneChanger(){
        scene.ToStartScene();
    }
}
