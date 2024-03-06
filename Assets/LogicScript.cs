using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text texto;
    public GameObject gameOverScreen;
    public bool isOver = true;
    
    [ContextMenu("Add Score")]
    public void addScore(){
    	playerScore = playerScore +1;
    	texto.text = playerScore.ToString();
    }
    
    public void restartGame(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void gameOver(){
    	gameOverScreen.SetActive(true);
    	isOver = false;
    }
    
    public void startGame(){
    	//SceneManager.UnloadSceneAsync("mainmenu");
    	SceneManager.LoadScene("flpbird");
    	//SceneManager.SetActiveScene(SceneManager.GetSceneByName("flpbird"));
    }
}
