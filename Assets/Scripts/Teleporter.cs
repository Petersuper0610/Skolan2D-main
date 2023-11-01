//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 Position;
    public Transform Player;
    private void OnTriggerEnter2D(Collider2D collision)
    
    {
        Player.position = Position;
        
    }
}
