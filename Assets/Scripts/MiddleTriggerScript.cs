using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleTriggerScript : MonoBehaviour
{
    public GameLogicScript gameLogic;

    // Start is called before the first frame update
    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameLogicScript>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameLogic.increaseScore();
    }
}
