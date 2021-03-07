using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hit : MonoBehaviour
{
    public string hit_per;
    private float timer;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<Text>().text = "miss";
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer <= 0)
        {
            text.SetActive(false);
        }
        else
        {
            text.SetActive(true);
            //Debug.Log("in");
            timer = timer - Time.deltaTime;
        }
        //Debug.Log(timer);
    }
    public void miss()
    {
        timer = 2f;

        text.GetComponent<Text>().text = "miss";
        //Debug.Log("in");
    }
    public void good()
    {
        timer = 2f;

        text.GetComponent<Text>().text = "good";
    }
    public void perfect()
    {
        timer = 2f;

        text.GetComponent<Text>().text = "perfect";
    }
}
