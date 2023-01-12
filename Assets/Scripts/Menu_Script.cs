using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Menu_Script : MonoBehaviour
{


    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 0);

    }

}