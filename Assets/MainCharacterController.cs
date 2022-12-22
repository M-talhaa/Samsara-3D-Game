using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCharacterController : MonoBehaviour
{
    public Animator animator;
    public float speed = 0.0f;
    public GameObject self;
    public int coinCount = 0;
    private static MainCharacterController _instance;
    private int healthPoints = 20;
    public HealthBar healthBar;
    public RuppeeCounter ruppeeUI;

    public static MainCharacterController Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("Player is null");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetMaxHealth(healthPoints);
        healthBar.SetHealth(healthPoints);
        ruppeeUI.SetRuppeeCount(0);
    }

    public void addCoin()
    {
        coinCount++;
        ruppeeUI.SetRuppeeCount(coinCount);
    }
    public int getCoinCount()
    {
        return coinCount;
    }

    public void reducehealth(int damage)
    {
        healthPoints -= damage;
        healthBar.SubtractHealth(damage);
    }
    public void increaseHealth(int toAdd)
    {
        healthPoints += toAdd;
        healthBar.AddHealth(toAdd);
    }
    public int getHealth()
    {
        return healthPoints;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetFloat("Moving", 0.5f);
        }
        else
        {
            animator.SetFloat("Moving", 0.0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("Right", true);
            //transform.Rotate(Vector3.up, 2.0f);
        }
        else {
            animator.SetBool("Right", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("Left", true);
        }
        else
        {
            animator.SetBool("Left", false);
        }
    }
}
