using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class poisonPillow : MonoBehaviour
{
    // 1
    void OnCollisionEnter(Collision collision)
    {
        // 2
        if (collision.gameObject.name == "Player")
        {
            // 3
            Destroy(this.transform.gameObject);
            // 4
            Debug.Log("The Evil Pillow has Inflicted You with Poision");
        }
    }
}