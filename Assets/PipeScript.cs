using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeScript : MonoBehaviour
{
	public Text texto;
	public int playerScore;
	public float moveSpeed = 5;
	public float deadZone = -15;
	public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        texto = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        playerScore = int.Parse(texto.text)/5;
        moveSpeed += playerScore;
    }

    // Update is called once per frame
    void Update()
    {
    	if(!logic.isOver) return;
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
	if(transform.position.x < deadZone){
		Debug.Log("Morreu");
		Destroy(gameObject);
	}
    }
}
