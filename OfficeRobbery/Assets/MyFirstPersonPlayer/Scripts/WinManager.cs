/*
* Gerard Lamoureux
* 5B
* Handles final win condition
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.score <= 0)
        {
            GameManager.Instance.OutofTime();
            GameObject.Find("/Canvas/Panel - GameOver/Paused").GetComponent<Text>().text = "You Win!";
            Destroy(gameObject);
        }
    }
}
