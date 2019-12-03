using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Chest : MonoBehaviour
{
    public TextMeshProUGUI levelCounter, coinCounter;
    public GameObject winnerPanel;
    public Animator anim;
    public GameObject x_mark;
    public GameObject openSound, closedSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            anim = GameObject.Find("Chest").GetComponent<Animator>();
            int levelNum = int.Parse(levelCounter.text);
            int numCoins = int.Parse(coinCounter.text);

            switch (levelNum)
            {
                case 5:
                    if (numCoins >= 10)
                    {
                        coinCounter.color = Color.green;
                        anim.SetBool("Wrong", false);
                        anim.Play("open");
                        Instantiate(openSound, transform.position, Quaternion.identity);
                        winnerPanel.SetActive(true);
                        Invoke("DelayedPause", 1f);
                    }
                    else
                    {
                        Debug.Log("Player only has: " + numCoins + " coins. Please collect more to open chest. ");
                        x_mark.SetActive(true);
                        anim.Play("wrong");
                        Instantiate(closedSound, transform.position, Quaternion.identity);
                        Invoke("TurnMeOff", 1f);
                    }
                    break;
                case 4:
                    if (numCoins >= 9)
                    {
                        coinCounter.color = Color.green;
                        anim.Play("open");
                        Instantiate(openSound, transform.position, Quaternion.identity);
                        winnerPanel.SetActive(true);
                        Invoke("DelayedPause", 1f);
                    }
                    else
                    {
                        Debug.Log("Player only has: " + numCoins + " coins. Please collect more to open chest. ");
                        x_mark.SetActive(true);
                        anim.Play("wrong");
                        Instantiate(closedSound, transform.position, Quaternion.identity);
                        Invoke("TurnMeOff", 1f);
                    }
                    break;
                case 3:
                    if (numCoins >= 8)
                    {
                        coinCounter.color = Color.green;
                        anim.Play("open");
                        Instantiate(openSound, transform.position, Quaternion.identity);
                        winnerPanel.SetActive(true);
                        Invoke("DelayedPause", 1f);
                    }
                    else
                    {
                        Debug.Log("Player only has: " + numCoins + " coins. Please collect more to open chest. ");
                        x_mark.SetActive(true);
                        anim.Play("wrong");
                        Instantiate(closedSound, transform.position, Quaternion.identity);
                        Invoke("TurnMeOff", 1f);
                    }
                    break;
                case 2:
                    if (numCoins >= 6)
                    {
                        coinCounter.color = Color.green;
                        anim.Play("open");
                        Instantiate(openSound, transform.position, Quaternion.identity);
                        winnerPanel.SetActive(true);
                        Invoke("DelayedPause", 1f);
                    }
                    else
                    {
                        Debug.Log("Player only has: " + numCoins + " coins. Please collect more to open chest. ");
                        x_mark.SetActive(true);
                        anim.Play("wrong");
                        Instantiate(closedSound, transform.position, Quaternion.identity);
                        Invoke("TurnMeOff", 1f);
                    }
                    break;
                default:
                    if(numCoins >= 5)
                    {
                        coinCounter.color = Color.green;
                        anim.Play("open");
                        Instantiate(openSound, transform.position, Quaternion.identity);
                        winnerPanel.SetActive(true);
                        Invoke("DelayedPause", 1f);
                    }
                    else
                    {
                        Debug.Log("Player only has: " + numCoins + " coins. Please collect more to open chest. ");
                        x_mark.SetActive(true);
                        anim.Play("wrong");
                        Instantiate(closedSound, transform.position, Quaternion.identity);
                        Invoke("TurnMeOff", 1f);
                    }
                    break;
            }
        }
    }

    public void DelayedPause()
    {
        Time.timeScale = 0f;
    }

    public void TurnMeOff()
    {
        x_mark.SetActive(false);
    }
}
