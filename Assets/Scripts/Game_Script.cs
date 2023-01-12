using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Script : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //ScoreScript.scoreValue = 0;
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene("Level Select");

    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Finish"))
        {
            NextLevel();
            //Debug.Log("Finish");
        }
    }
}