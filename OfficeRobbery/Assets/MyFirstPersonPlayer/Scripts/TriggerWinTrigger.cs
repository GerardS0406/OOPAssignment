/*
* Gerard Lamoureux
* 5B
* Handles Win Trigger
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerWinTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    void OnTriggerEnter(Collider theCollider)
    {
        if (theCollider.CompareTag ("Player") && GameManager.Instance.score >= 6) {
            GameManager.Instance.UnloadCurrentLevel();
            GameManager.Instance.LoadLevel("Outside");
            Destroy(gameObject);
        }
    }
}
