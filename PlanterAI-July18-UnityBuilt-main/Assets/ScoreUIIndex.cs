using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUIIndex : MonoBehaviour
{
    public TMP_Text Time;
    public TMP_Text A0;
    public TMP_Text A1;
    public TMP_Text A2;
    public TMP_Text A3;

    public void NewScoreElement(float a0, float a1, float a2, float a3, string time)
    {
        Time.text = time;
       // A0.text = a0.ToString("f0") + "%";
        A0.text = a0.ToString("f0");
        A1.text = a1.ToString("f0");
        A2.text = a2.ToString("f0");
        A3.text = a3.ToString("f0");
    }
}
