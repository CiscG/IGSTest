using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject game;
  
    public void GameStart()
    {
        game.gameObject.SetActive(true);
    }

    public void ExitGame()
    {
        game.gameObject.SetActive(false);
    }
}
