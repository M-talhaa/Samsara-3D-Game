using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class startButton : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField]
    private Button button;
    void RunThisTask()
    {
        SceneManager.LoadScene("SampleScene");
    }
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => RunThisTask());
        //button.onClick.AddListener(RunThisTask);
    }
    // Update is called once per frame
    void Update()
    {
    }
}