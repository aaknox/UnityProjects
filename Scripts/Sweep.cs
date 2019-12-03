using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sweep : MonoBehaviour
{
    private GameObject[] poops;
    private TextMeshProUGUI coinText;
    public GameObject sweepSound;
    private void Start()
    {
        coinText = GameObject.Find("MoneyCounter").GetComponent<TextMeshProUGUI>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            //decrement a coin from money bag counter
            CoinUI.coinCounter--;
            //display new count to TMPro
            coinText.text = CoinUI.coinCounter.ToString();
            //add all poop items to array
            poops = GameObject.FindGameObjectsWithTag("Poop");
            Debug.Log(poops.Length);
            //destroy all poops in foreach loop
            foreach (GameObject item in poops)
            {
                Destroy(item);
            }
            //destroy broomster object
            Instantiate(sweepSound, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
