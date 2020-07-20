using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.VFX;

public class ScoreKeeper : MonoBehaviour
{
  

    Text scoreText;
    int score = 0;
    public GameObject star;


    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
        
    }


    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();

        if (score == 11)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

  



}
