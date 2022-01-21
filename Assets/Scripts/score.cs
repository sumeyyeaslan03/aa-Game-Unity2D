using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int pinCount;

    void Start()
    {
        pinCount=0;
    }

    
    void Update()
    {
        scoreText.text=pinCount.ToString();
    }
}
