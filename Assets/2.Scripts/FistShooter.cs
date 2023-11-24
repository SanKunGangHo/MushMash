using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistShooter : MonoBehaviour
{
    public GameObject Fist;
    public AudioSource _audio = new AudioSource();

    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _audio.Play();
            GameObject punch = Instantiate(Fist, this.transform.position, this.transform.rotation);
            if (UserData._LevelUp || UserData._FireUp)
            {
                punch.GetComponent<fistMove>().punchSpeed = 8;
            }
        }
    }
}
