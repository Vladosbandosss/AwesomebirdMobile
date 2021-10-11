using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        DeactiveteGround();
    }
    void DeactiveteGround()
    {
        if (Camera.main.transform.position.y > transform.position.y + 9f)
        {
            Spawner.instanse.SpawnMoreGrounds();
            gameObject.SetActive(false);
        }
    }
}
