using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StatsManagerScript : MonoBehaviour
{
    int score = 0;
    int balls = 3;

    public TextMeshPro scoreText;
    public TextMeshPro ballsText;

     public GameObject ball;

     Transform ballTrans;

     Rigidbody ballRigidbody;

    public Transform ballSpawnPoint;

    public GameObject gameOverScreen;

    bool gameOver = false;



    void Start()
    {
       ballTrans = ball.GetComponent<Transform>();
       ballRigidbody = ball.GetComponent<Rigidbody>();
       
       scoreText.text = "Score: " + score;
       ballsText.text = "Balls: " + balls;  
    }

    void Update(){
        if(gameOver){
            if(Input.GetKey(KeyCode.Escape)){
                Application.Quit();
            }
            if(Input.GetKey(KeyCode.Space)){
                Time.timeScale = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    public void AddPoints(int points){
        score += points;
        scoreText.text = "Score: " + score;
    }

    public void LooseBall(){

     balls--;

        if(balls >= 0){
            ballsText.text = "Balls: " + balls;
            NewBall();
        }else{
            gameOverScreen.SetActive(true);
            gameOver = true;
            Time.timeScale = 0;
        }
    }

    public void AddBall(){
        balls++;
        ballsText.text = "Balls: " + balls;
    }


    private void NewBall(){
        ballRigidbody.velocity = Vector3.zero;
        ballTrans.position = ballSpawnPoint.position;
    }
}
