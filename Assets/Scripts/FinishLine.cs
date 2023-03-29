using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinishLine : MonoBehaviour
{
    public static bool racestarted;

    public TextMeshProUGUI timeText;

    public static bool countDown;
    public static float currentTime;

    public static float sessionBestTime = 9999f;
    public static float lastRaceTime = 0;

    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        if(racestarted){
            timeText.text = currentTime.ToString("F2");
        } else {
            timeText.text = "Latest Race Time: " + lastRaceTime.ToString("F2") + "           Session Best Time: " + sessionBestTime.ToString("F2");
        }
        
    }

    private void OnTriggerEnter(Collider collision){
        toggleRacing();
    }

    public void toggleRacing(){
        if(racestarted){
            Debug.Log("Timer stopped ");
            racestarted = false;
            lastRaceTime = currentTime;
            if(lastRaceTime < sessionBestTime){
                sessionBestTime = lastRaceTime;
            }

        }   else {
            Debug.Log("Timer started ");
            racestarted = true;
            currentTime = 0;
        }
    }
}
