using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int power = 1;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI tenMark;
    public TextMeshProUGUI troll;
    public void clicker()
    {
        score = score+power;
        scoreText.text = "score: " + score;

        if (score >= 10)
        {
            tenMark.text = "you hit 10 !";
        }
        else
        {
            tenMark.text = " ";
        }




    }
    
    public void shop()
    {
        troll.text = "nothing happens lol ";
        
       
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
