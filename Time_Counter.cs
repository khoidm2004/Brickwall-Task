using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class TimeCounter : MonoBehaviour
{   
    public DateTime StartTime;
    public DateTime WinTime;
    public TMP_Text resultText;
    public TimeSpan elapsed;
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartTime = DateTime.Now;
            Debug.Log(StartTime);
        }

        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            WinTime = DateTime.Now;
            Debug.Log(WinTime);
        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            elapsed = WinTime - StartTime;
            resultText.text = "Elapsed Time:"+ elapsed.ToString();
        }
    }
}
