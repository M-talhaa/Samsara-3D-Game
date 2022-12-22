using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuppeeUIScript : MonoBehaviour
{
    public Text ruppeeCount;

    void Start()
    {
        ruppeeCount = GameObject.Find("RuppeeUI").GetComponent<Text>();
        Debug.Log(ruppeeCount);
    }

    public void SetRuppeeCount(int newCount)
    {
        ruppeeCount.text = newCount.ToString();
    }
}
