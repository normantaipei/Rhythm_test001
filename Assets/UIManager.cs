using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject[] controler;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
       controler= GameObject.FindGameObjectsWithTag("pointer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameStart()
    {
        for(int i=0;i<5; i++)
        {
            controler[i].GetComponent<gameMove>().gameStart = true;
        }
        button.SetActive(false);
    }
}
