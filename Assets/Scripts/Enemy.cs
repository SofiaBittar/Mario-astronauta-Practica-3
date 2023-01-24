using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speedEnemy = 2f;
    private Vector2 position;
    public GameObject target; 
   
  
  

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float step = speedEnemy * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position ,step);
    }
}   

