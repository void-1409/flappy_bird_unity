using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void increaseScore()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }
}
