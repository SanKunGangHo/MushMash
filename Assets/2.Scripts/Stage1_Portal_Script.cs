using UnityEngine;

public class Stage1_Portal_Script : MonoBehaviour
{
    public GameObject player;
    public GameObject warpPoint;
    [SerializeField]private Vector3 vector;
    public MainBGMChanger changer;

    // Start is called before the first frame update
    void Start()
    {
        vector = warpPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            changer.ClipChange();
            Debug.Log(other.gameObject.name);
            player.transform.position = vector;
            Debug.Log(vector + "로 이동함.");
        }
    }
}
