using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject bird;
    public GameObject spawnPipe;
    public GameObject gameStartScreen;
    public GameObject gameOverScreen;

    private void Start()
    {
        gameStartScreen.SetActive(true);
        bird.SetActive(false);
        spawnPipe.SetActive(false);
    }

    public void startGame()
    {
        gameStartScreen.SetActive(false);
        bird.SetActive(true);
        spawnPipe.SetActive(true);
    }
    public void increaseScore()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
