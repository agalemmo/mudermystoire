using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    //when flashlight is attached to player (look to code regarding when character in platform picks up gun) becomes a child of playercharacter
    // Use this for initialization
    void Awake()
    {
        transform.parent = false;
    }

    //once triggered transform.parent = true;
    //once triggered release the sprite & collider boxes go away.
}