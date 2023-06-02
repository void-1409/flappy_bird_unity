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
        bird.GetComponent<Rigidbody2D>().gravityScale = 0f;
        spawnPipe.SetActive(false);
    }

    public void startGame()
    {
        gameStartScreen.SetActive(false);
        bird.GetComponent<Rigidbody2D>().gravityScale = 5f;
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
