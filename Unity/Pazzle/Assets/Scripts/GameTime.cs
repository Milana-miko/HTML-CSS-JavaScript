using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameTime : MonoBehaviour
{

    public int minute1, minute2, second1, second2;
    private float game_time;
    private Text myText;
    public GameObject GameOver;



    void Start()
    {
        myText = GetComponent<Text>();
        GameOver.SetActive(false); 
    }

       void Update()
    {
        myText.text = "" + minute1 + minute2 + ":" + second1 + second2;
        game_time += 1 * Time.deltaTime;
        

        if (game_time > 1) {
            second2 += 1;
            game_time = 0;
       }

        if (second1 == 5 & second2 ==9)
        {
            minute2 += 1;
            second1 = 0;
            second2 = 0;
        }

        if (minute2 > 9) {
            minute1 += 1;
            minute2 = 0;
        }

        if (second2 == 9)
        {
            second1 += 1;
            second2 = 0;
        }

        if (minute1 == 1 & minute2 == 0) {
            GameOver.SetActive(true);
            minute1 = 1;
            minute2 = 0;
            second1 = 0;
            second2 = 0;
         
        }
     
    }
}
