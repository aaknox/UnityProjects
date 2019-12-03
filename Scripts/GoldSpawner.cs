using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldSpawner : MonoBehaviour
{
    public float timeLeft;
    private float defaultTimeSet;
    public bool isTimeGone = false;
    public Transform[] points;
    public GameObject goldSound;

    private void Start()
    {
        timeLeft = Random.Range(10f, 90f);
        defaultTimeSet = timeLeft; //placeholder
    }
    // Update is called once per frame

    void Update()
    {
        
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            isTimeGone = true;
            int rand = Random.Range(0, points.Length);
            Instantiate(points[rand], points[rand].transform.position, Quaternion.identity);
            Instantiate(goldSound, transform.position, Quaternion.identity);
            timeLeft = defaultTimeSet;
            //Debug.Log("Storm made. ");
        }
        else
        {
            isTimeGone = false;
            //Debug.Log("Storm coming in: " + Mathf.RoundToInt(timeLeft));
        }
    }
}
