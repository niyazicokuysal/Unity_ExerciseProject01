using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreboard;


    // Update is called once per frame
    void Update()
    {
        scoreboard.text = player.position.z.ToString("0");
    }
}
