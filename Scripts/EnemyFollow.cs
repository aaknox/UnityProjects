using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;
    private Animator anim;
    public GameObject loserPanel;
    private bool touched = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.Find("Player").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //check if cop touched the player
        if(touched == true)
        {
            loserPanel.SetActive(true);
            Invoke("DelayedScreenFrezze", 1.2f);
        }
        else
        {
            touched = false;
        }
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            anim.Play("death");
            touched = true;
        }
    }

    void DelayedScreenFrezze()
    {
        Time.timeScale = 0f;
    }
}
