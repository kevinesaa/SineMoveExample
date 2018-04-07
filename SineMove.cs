using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//castlevania's medusa head
public class SineMove : MonoBehaviour {
    
    public float horizontalSpeed;
    public float verticalAmplitude;
    public float numbersOfPI = 1;
    public bool positveAndNegative = true;
    public bool positive = true;

    private Vector3 startPosition;
	// Use this for initialization
	void Start () {
        startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 currentPosition = transform.position;
        currentPosition.x += horizontalSpeed * Time.deltaTime;
        currentPosition.y = startPosition.y + verticalAmplitude * Mathf.Sin(numbersOfPI * Mathf.PI * (currentPosition.x ));
        if (!positveAndNegative)
        {
            currentPosition.y = Mathf.Abs(currentPosition.y);
            if (!positive)
            {
                currentPosition.y *= (-1);
            }
        }
       
        transform.position = currentPosition;
	}
}
