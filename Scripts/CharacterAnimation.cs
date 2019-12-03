using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.Find("Player").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("isLeft", true);
        }
        else
        {
            anim.SetBool("isLeft", false);
        }
        //right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isRight", true);
        }
        else
        {
            anim.SetBool("isRight", false);
        }
        //up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("isUp", true);
        }
        else
        {
            anim.SetBool("isUp", false);
        }
        //down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("isDown", true);
        }
        else
        {
            anim.SetBool("isDown", false);
        }
    }
}
