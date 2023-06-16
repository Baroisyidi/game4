using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logScript : MonoBehaviour
{
    public int PlayerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void morescore(int scoreToadd)
    {
        PlayerScore = PlayerScore + scoreToadd;
        scoreText.text = PlayerScore.ToString();
    }
}
