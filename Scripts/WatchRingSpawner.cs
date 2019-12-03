using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchRingSpawner : MonoBehaviour
{
    public float timeLeft;
    public float defaultTimeSet;
    public bool isTimeGone = false;
    public Transform[] points;
    public GameObject sound;
    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;


        if (timeLeft <= 0)
        {
            isTimeGone = true;
            int rand = Random.Range(0, points.Length);
            Instantiate(points[rand], points[rand].transform.position, Quaternion.identity);
            Instantiate(sound, transform.position, Quaternion.identity);
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
