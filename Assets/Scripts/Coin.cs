using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public TextManager textManager;
    public int value;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        textManager.AddCoins(value);
        Destroy(gameObject);
    }
}
