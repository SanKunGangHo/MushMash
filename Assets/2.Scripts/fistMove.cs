using UnityEngine;

public class fistMove : MonoBehaviour
{
    public Renderer thisRenderer;
    public GameObject fire;
    [SerializeField] private Rigidbody rb;
    public float punchSpeed = 0.8f;
    public float disappearDelay = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        if (UserData._LevelUp)
        {
            thisRenderer.material.color = new Color(0.4705f, 0.2156f, 0.4274f, 1);
        }
        if (UserData._FireUp)
        {
            thisRenderer.material.color = new Color(1, 0.3098f, 0, 1);
            fire.SetActive(true);
        }
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * punchSpeed, ForceMode.Impulse);
        Invoke("PunchEnd", disappearDelay);
    }

    void PunchEnd()
    {
        Destroy(gameObject);
    }
}
