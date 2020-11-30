using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{
    public int Lives;
    public int Score;
    public Text LivesText;
    public Text LevelText;
    public Text ScoreText;
    public bool LevelFailed;
    public GameObject GAMEOVER;
    public int BrickSum;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        BrickSum=GameObject.FindGameObjectsWithTag("BrickTag").Length;//add here the tag for bad bricks
        LivesText.text="Lives: "+Lives;
        ScoreText.text="Score: "+Score;
        LevelText.text=SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LivesDecrese(){
        Lives--;
        if(Lives<=0){
            Lives=0;
            LevelFailed=true;
            GAMEOVER.SetActive(true);
        }
        LivesText.text="Lives: "+Lives;
    }
    public void ScoreIncrese(){
        Score++;
        ScoreText.text="Score: "+Score;
    }
    public void ScoreDecrese(){
        Score--;
        ScoreText.text="Score: "+Score;
    }
    public void PLAYAGAIN(){
    if(SceneManager.GetActiveScene().name.StartsWith("Game")){
        SceneManager.LoadScene("Level 1");
    }
    else{
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }   
    }
    public void BrickSumDecrease(){
        BrickSum--;
        if(BrickSum<=0){
            SceneManager.LoadScene(sceneName);
        }
    }
}
