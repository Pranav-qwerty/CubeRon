using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    public Transform player;
    public Text score;
    void Update()
    {
        score.text = player.position.z.ToString("0");
    }
}
