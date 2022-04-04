/*
* Gerard Lamoureux
* 6
* Handles Collectable Papers to Win Game
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCoin : Collectables
{
    public int scoreReceived;
    void OnTriggerEnter(Collider theCollider)
    {
        if (theCollider.CompareTag ("Player")) {
            collectItem(scoreReceived);
        }
    }
    public override void collectItem(int score)
    {
        GameManager.Instance.score += score;
        Destroy(gameObject);
    }
}
