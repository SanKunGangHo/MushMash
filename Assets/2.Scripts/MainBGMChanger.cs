using UnityEngine;

public class MainBGMChanger : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public int clipCheck = 1;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void ClipChange()
    {
        clipCheck++;
        Invoke("ClipStart", 1f);
    }

    private void Update()
    {
        if (clipCheck == 1)
        {
            audioSource.clip = audioClips[0];
        }

        if (clipCheck == 2)
        {
            audioSource.clip = audioClips[1];
        }

        if (clipCheck == 3)
        {
            audioSource.clip = audioClips[2];
        }

        if(clipCheck ==4)
        {
            audioSource.clip = audioClips[4];
        }
    }

    public void ClipStart()
    {
        audioSource.Play();
    }
}
