using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public void BackToStart()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
