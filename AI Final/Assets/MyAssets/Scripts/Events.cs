using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour
{
    public GameObject Amount;
    public GameObject ThisCoin;
    public int RotateSpeed = 2;
    public int CoinAmount = 0;

    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(0, RotateSpeed, 0, Space.World);
        
    }

    void OnTriggerEnter()
    {
        CoinAmount = CoinAmount + 1;
        ThisCoin.SetActive(false);
        //Text setText;
        //setText = Amount.GetComponent<Text>();
        //setText.text = Convert.ToString(CoinAmount);


    }
}
