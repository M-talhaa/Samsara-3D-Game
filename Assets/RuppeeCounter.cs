using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuppeeCounter : MonoBehaviour
{
    public Text ruppeeCount;

    void Start()
    {
        ruppeeCount = GameObject.Find("RuppeeUI2").GetComponent<Text>();
        Debug.Log(ruppeeCount);
    }
    
    public void SetRuppeeCount(int newCount)
    {
        ruppeeCount.text = newCount.ToString();
    }
}
