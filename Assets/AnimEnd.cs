using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnimEnd : MonoBehaviour
{
    public Image endImage;
    public Animator animator;

    public AudioSource mainAudio;
    public bool _isEnd;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        if(endImage.color.a >= 0.9){
            SceneManager.LoadScene(2);
        }

        if(_isEnd){
            animator.SetBool("isEnd", false);
            mainAudio.Stop();
        }
    }
    
}
