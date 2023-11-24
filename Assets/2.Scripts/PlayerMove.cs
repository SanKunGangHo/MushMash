using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private Vector3 moveDirection;
    public float moveSpeed = 0f, normalSpeed= 100f, runSpeed = 200f, jumpPower = 5f;

    public Rigidbody rb;
    public bool isGrounded = true;
    public GameObject CoinPrefab;

    public GameObject shooter;
    public BoxCollider area;

    public AudioSource moveSound, loseCoin;

    // Start is called before the first frame update
    void Start()
    {  
        rb = this.gameObject.GetComponent<Rigidbody>();
        moveSpeed = normalSpeed;
        area = shooter.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, 1.4f);
       
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded )
        {
            OnJump();
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = runSpeed;
            moveSound.pitch = 1.5f;
        }
        else
        {
            moveSpeed = normalSpeed;
            moveSound.pitch = 1.0f;
        }

        if (GameManager.instance.GameEnd)
        {
            this.gameObject.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        OnMove();
    }

    public void OnMove(){
        float fallSpeed = rb.velocity.y;
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")); //수평수직입력 WASD
        Vector3 worldDirection = transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime;
        worldDirection.y = fallSpeed;
        rb.velocity = worldDirection;

        if(moveDirection != Vector3.zero)
        {
            if (!moveSound.isPlaying)
            {
                moveSound.Play();
            }
        }
        else
        {
            moveSound.Stop();
        }
    }

    public void OnJump()
    {
        rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        isGrounded = false;
    }

    public void damaged(int i)
    {
        for(int j = 0; j < i; j++)
        {
            if(UserData.Coins > 0) {
                Vector3 spawnPos = GetRandomPosition();
                loseCoin.Play();
                Instantiate(CoinPrefab, spawnPos, Quaternion.identity);
                GameManager.instance.CoinLose();
            }else if(UserData.Coins < 0)
            {
                return;
            }
        }
    }

    public Vector3 GetRandomPosition()
    {
        Vector3 basePosition = shooter.transform.position;
        Vector3 size = area.size;

        float posX = basePosition.x + Random.Range(-size.x/2f, size.x/2f);
        float posY = basePosition.y + Random.Range(-size.y/2f, size.y/2f);
        float posZ = basePosition.z + Random.Range(-size.z / 2f, size.z / 2f);

        Vector3 spawnPos = new Vector3(posX, posY, posZ);

        return spawnPos;
    }
}
