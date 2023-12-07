using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int coins;
    private void OnTriggerEnter2D(Collider2D that)
    {
        if (that.name == "Bob")
        {
            coins++;
            Destroy(gameObject);
        }
    }
}
