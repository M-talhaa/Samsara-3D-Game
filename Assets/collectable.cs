using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    // public int coinCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            MainCharacterController.Instance.addCoin();
           //aintance.AddCoins();
            Debug.Log("You got a coin");
            Debug.Log(MainCharacterController.Instance.getCoinCount());
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
