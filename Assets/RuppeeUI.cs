using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuppeeUI : MonoBehaviour
{
    public Text ruppeeCount;

    public void SetRuppeeCount(int newCount)
    {

        ruppeeCount.text = newCount.ToString();
    }
}
