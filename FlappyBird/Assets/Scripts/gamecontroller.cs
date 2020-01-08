using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamecontroller : MonoBehaviour
{

    public static gamecontroller instance;
    public bool gameover = false;
    public GameObject gameovertext;
    public float scrollspeed = -1.5f;

    private int score = 0;
    public Text scoretext;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if ( instance != this)
        {
            Destroy(gameObject);
                }

    }
    void Update()
    {
        if( gameover == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        
    }
    public void BirdDied()
    {
        gameovertext.SetActive(true);
        gameover = true;
    }
    public void Birdscored ()
    {
        if (gameover)
        { return; }
        score++;
        scoretext.text = "Score : " + score.ToString();
    }
}
