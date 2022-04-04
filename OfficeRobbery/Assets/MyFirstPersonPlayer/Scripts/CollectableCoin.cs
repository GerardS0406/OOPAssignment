/*
* Gerard Lamoureux
* 5B
* Handles Collectable Papers to Win Game
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0,1,0);
    }

    void OnTriggerEnter(Collider theCollider)
    {
        if (theCollider.CompareTag ("Player")) {
            GameManager.Instance.score++;
            Destroy(gameObject);
        }
    }
}
