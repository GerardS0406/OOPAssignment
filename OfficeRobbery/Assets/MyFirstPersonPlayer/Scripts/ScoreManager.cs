/*
* Gerard Lamoureux
* 5B
* Handles Score and Score UI
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        textbox = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Pages: " + GameManager.Instance.score;
        if(GameManager.Instance.score >= 6 && GameObject.Find("/WorldCanvas/DoorText") != null)
            Destroy(GameObject.Find("/WorldCanvas/DoorText"));
    }
}
