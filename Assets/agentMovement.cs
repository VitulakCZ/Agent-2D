using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agentMovement : MonoBehaviour
{
    // Object Variables
    Rigidbody2D rb;
    Vector2 movement;
    GameObject square;
    
    public float playerSpeed = 5;
    private float x = 0f;
    private float y = 0f;
	
	// kolize
	bool[] kolize(float x, float y) {
		bool[] zatim = {true, true, true, true};
		if (y < 4.6f)
			zatim[0] = false;
		if (y >= -4.6f)
			zatim[1] = false;
		if (x >= -9.8f)
			zatim[2] = false;
		if (x < 9.8f)
			zatim[3] = false;
		return zatim;
	}
	
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    	rb.velocity = new Vector2(x, y);
    	// kolize
    	bool[] kolize_bool = kolize(x, y);
    	print(kolize_bool[0]);
    	if (!kolize_bool[0]) {
			if (Input.GetKey("w"))
				y += .1f;
		}
		if (!kolize_bool[2]) {
			if (Input.GetKey("a"))
				x -= .1f;
		}
		if (!kolize_bool[3]) {
			if (Input.GetKey("d"))
				x += .1f;
		}
		if (!kolize_bool[1]) {
			if (Input.GetKey("s"))
    		y -= .1f;
    	}
    	print(x + " " + y);
    	
        rb.MovePosition(rb.position + movement * playerSpeed * Time.deltaTime);
    }
}
