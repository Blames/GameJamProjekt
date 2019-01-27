using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pnj1 : MonoBehaviour {

	[SerializeField]
    private float speed;
    private Vector2 direction;

	[SerializeField]
    private stat health;

	private void Awake()
    {
        health.Initialize();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Move();
		healthBar();
	}

	public void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }   
    }

	public void healthBar()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            health.CurrentVal -= 10;

        }else if (Input.GetKeyDown(KeyCode.E))
        {
            health.CurrentVal += 10;
        }
    }

	
}
