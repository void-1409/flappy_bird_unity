using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdBody;
    public float jumpStrength;
    public GameLogicScript logic;
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameLogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                birdBody.velocity = Vector2.up * jumpStrength;
            }

            Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
            if (screenPos.y >= Screen.height || screenPos.y <= 0)
            {
                logic.gameOver();
                isGameOver = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isGameOver = true;
    }
}
