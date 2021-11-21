using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public float dayDelay = 10f;
    public float lastDayTime;
    private int dayTime;

    public Text scoreLabel;
    public Text clock;

    private void Awake()
    {
        dayTime = 6;
        PersistanceManager.instance.playing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastDayTime > dayDelay && PersistanceManager.instance.playing == true){
            dayTime++;
            lastDayTime = Time.time;
        }
        if(dayTime < 12){
            clock.text = " " + dayTime + "am";
        }
        if(dayTime == 12){
            clock.text = " " + dayTime + "pm";
        }
        if(dayTime > 12){
            clock.text = " " + (dayTime - 12) + "pm";
        }
        if(dayTime > 24){
            dayTime = 6;
        }  

        scoreLabel.text = "Money: " + PersistanceManager.instance.score + "gp";
        
        if(dayTime == 21)
        {
            SceneManager.LoadScene("DayEnd");
        }
    }
}
