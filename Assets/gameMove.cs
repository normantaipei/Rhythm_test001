using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMove : MonoBehaviour
{
    public float move_speed=60;
    public bool gameStart = false;
    // Start is called before the first frame update
    void Start()
    {
        move_speed = 570f;
        move_speed = move_speed / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStart)
        {
            this.transform.position += new Vector3(0f, 0f, move_speed * Time.deltaTime);
        }
        
    }
 
}
