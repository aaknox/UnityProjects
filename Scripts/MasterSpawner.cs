using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterSpawner : MonoBehaviour
{
    private float timeBtwSpawns = 3f;
    private float repeat = 1f;
    public Transform[] poopPoints;
    public GameObject poop; //poop point position
    //private Vector2 targetDir; //player direction
    private float spawnDistance = 1f;

    

    private void Start()
    {
        //target = GameObject.Find("PoopPoint").transform;
        InvokeRepeating("Poop", timeBtwSpawns, repeat);
    }

    void Poop()
    {
        //working code
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //spawn above player
            Instantiate(poop, Vector2.MoveTowards(transform.position, (poopPoints[0].forward + -transform.forward) * spawnDistance, repeat), Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //spawn below player
            Instantiate(poop, Vector2.MoveTowards(transform.position, (poopPoints[1].forward + -transform.forward) * spawnDistance, repeat), Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //spawn on player's right side
            Instantiate(poop, Vector2.MoveTowards(transform.position, (poopPoints[2].forward + -transform.forward) * spawnDistance, repeat), Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //spawn on player's left side
            Instantiate(poop, Vector2.MoveTowards(transform.position, (poopPoints[3].forward + -transform.forward) * spawnDistance, repeat), Quaternion.identity);
        }
        
    }
}
