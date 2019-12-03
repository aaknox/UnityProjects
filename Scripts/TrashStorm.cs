using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashStorm : MonoBehaviour
{
    public float timeLeft = 30f;
    private float defaultTimeSet = 30f;
    public bool isTimeGone = false;
    public GameObject apple, fish, banana, dirt, paper, can;
    public Transform point;
    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        

        if (timeLeft <= 0)
        {
            isTimeGone = true;
            Instantiate(apple, point.transform.position, Quaternion.identity);
            Instantiate(banana, point.transform.position, Quaternion.identity);
            Instantiate(can, point.transform.position, Quaternion.identity);
            Instantiate(dirt, point.transform.position, Quaternion.identity);
            Instantiate(fish, point.transform.position, Quaternion.identity);
            Instantiate(paper,point.transform.position, Quaternion.identity);
            timeLeft = defaultTimeSet;
            Debug.Log("Storm made. ");
        }
        else
        {
            isTimeGone = false;
            //Debug.Log("Storm coming in: " + Mathf.RoundToInt(timeLeft));
        }
    }
}
