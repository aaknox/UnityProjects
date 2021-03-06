﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldUI : MonoBehaviour
{
    public TextMeshProUGUI coinCounterText;
    public GameObject sound;

    private void Start()
    {
        coinCounterText = GameObject.Find("MoneyCounter").GetComponent<TextMeshProUGUI>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            //increment coin counter
            CoinUI.coinCounter += 5;
            //add new count to TMPro
            coinCounterText.text = CoinUI.coinCounter.ToString();
            Instantiate(sound, transform.position, Quaternion.identity);
            //destroy coin
            Destroy(this.gameObject);
        }
    }
}
