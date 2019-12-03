using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public GameObject endingMusic;
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Update()
    {
        PlayEnding();
    }

    void PlayEnding()
    {
        if (SceneManager.GetActiveScene().name.Equals("Ending")) 
        {
            Instantiate(endingMusic, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
