using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject[] points;
    public GameObject switchSound;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Instantiate(switchSound, transform.position, Quaternion.identity);
            int rand = Random.Range(0, points.Length);
            Instantiate(points[rand], points[rand].transform.position, Quaternion.identity);
        }
    }
}
