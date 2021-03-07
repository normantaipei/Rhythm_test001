using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private float total=0;
    public GameObject pop;
    // Start is called before the first frame update
    void Start()
    {
        //pop= GameObject.FindGameObjectsWithTag("Text");
        pop.GetComponent<Text>().text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        pop.GetComponent<Text>().text = total.ToString();
        Debug.Log(total);
    }
    public void getPoint()
    {
        total = total + 10;
    }
    public void costPoint()
    {
        if (total > 20)
        {
            total = total - 20;
        }
        else
        {
            total = 0;
        }
        
    }
}
