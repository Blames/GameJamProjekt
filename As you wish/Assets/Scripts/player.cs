using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class player : MonoBehaviour {

    [SerializeField]
    private float speed;
    private Vector2 direction;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();
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

    public void collision()
    {

    }
}
