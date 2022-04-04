/*
* Gerard Lamoureux
* 5B
* Handles Generic Collectables
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectables : MonoBehaviour, ICollectable
{
    public abstract void collectItem(int score);

    void Update()
    {
        gameObject.transform.Rotate(0, 1, 0);
    }
}
