using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{

    public float playerSpeed = 1f;

    private Vector2 playerPos = new Vector2(0, 0);

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal")) * paddleSpeed;
        playerPos = new Vector2(Mathf.Clamp(xPos, -2.84f, 2.84f), -1.8f);
        transform.position = playerPos;
    }
}
