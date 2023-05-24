using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    public Text coinText;
    int coins;


    void Update()
    {

    }

    public void GameOver()
    {
        isGameOver = true;
    }

    public void AddCoin()
    {
        coins++;
        coinText.text = coins.ToString();
    }
    public void DeathGoomba(GameObject goomba)
    {
       
        Animator goombaAnimator;
        
        Enemy goombaScript;
       
        BoxCollider2D goombaCollider;

        
        goombaScript = goomba.GetComponent<Enemy>();
        goombaAnimator = goomba.GetComponent<Animator>();
        goombaCollider = goomba.GetComponent<BoxCollider2D>();

       
        goombaAnimator.SetBool("GoombaDeath", true);

    
        goombaCollider.enabled = false;

        
        Destroy(goomba, 0.3f);

       
        
    }
}
