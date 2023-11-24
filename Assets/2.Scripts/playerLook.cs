using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLook : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = 0.5f;
    public bool Level1;
    public bool Fire1;

    public GameObject Player;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        turn.y += Input.GetAxis("Mouse X")*sensitivity;

        turn.x += Input.GetAxis("Mouse Y")*sensitivity;
        turn.x = Mathf.Clamp(turn.x, -45f, 45f);
        Player.transform.localRotation = Quaternion.Euler(0, turn.y, 0);
        transform.localRotation = Quaternion.Euler(-turn.x, 0, 0);
    }
}
