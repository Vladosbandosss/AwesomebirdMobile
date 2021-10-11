using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondCheker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameManger.instance.IncreaseScore();
        }
    }
}
