/*
* Gerard Lamoureux
* 5B
* Handles Timer for Challenge
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public float timeToPlay = 90f;

    // Update is called once per frame
    void Update()
    {
        if(timeToPlay > 0)
        {
            timeToPlay -= Time.deltaTime;
        }
        else
        {
            timeToPlay = 0;
            GameManager.Instance.OutofTime();
            GameObject.Find("/Canvas/Panel - GameOver/Paused").GetComponent<Text>().text = "Out of Time!";
            Destroy(gameObject);
        }
        gameObject.GetComponent<Text>().text = "Time Left: " + (int)timeToPlay;
    }
}
