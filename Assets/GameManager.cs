using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool  gameHasEnded = false;

    public rotateCircle circle;
    public spawner spawner;

    public void EndGame()
    {
        if(gameHasEnded)
        {
            return;
        }

        circle.enabled = false;
        spawner.enabled = false;

        gameHasEnded = true;
    }
}
