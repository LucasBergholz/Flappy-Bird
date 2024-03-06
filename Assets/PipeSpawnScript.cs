using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeSpawnScript : MonoBehaviour
{
	public GameObject pipe;
	public Text texto;
	public int playerScore;
	public float spawnRate = 2;
	private float timer = 0;
	public float heightOffset = 10;
	public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
       spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
    	if(!logic.isOver) return;
	if(timer < spawnRate){
		timer += Time.deltaTime;
	} else {
		spawnPipe();
		timer = 0;
	}
        
    }

	void spawnPipe() {
		texto = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        	playerScore = int.Parse(texto.text)/10;
        	if(spawnRate > (1/2)) spawnRate -= playerScore;
        	if(spawnRate <= 0) spawnRate = 1;
		float lowestPoint = transform.position.y - heightOffset;
		float highestPoint = transform.position.y + heightOffset;
		Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);	
	}
}
