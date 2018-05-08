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
        float xPos = transform.position.x + (Input.GetAxis("Horizontal")) * playerSpeed; //account for wasd as well
        float yPos = transform.position.y + (Input.GetAxis("Vertical")) * playerSpeed;
        playerPos = new Vector2(xPos, yPos);
        transform.position = playerPos;
    }

    //on trigger enter method for e key. look up platformer tutorial for this.
}
