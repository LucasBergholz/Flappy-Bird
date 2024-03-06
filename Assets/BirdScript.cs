using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

	public Rigidbody2D myBody;
	public float flapStrength;
	public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetKeyDown(KeyCode.Space) && logic.isOver) {
    		myBody.velocity = Vector2.up * flapStrength;
    	}
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision){
    	logic.gameOver();
    }
}
