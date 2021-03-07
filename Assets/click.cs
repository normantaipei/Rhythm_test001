using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public string button_name;
    public GameObject target;
    public GameObject GM;
    public GameObject hit;
    //public var 
    // Start is called before the first frame update
    void Start()
    {
       // target=GameObject.FindGameObjectsWithTag("target01");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(target);
        if (Input.GetKeyDown(button_name))
        {
            if (target != null)
            {
                target.SetActive(false);
                if (Vector3.Distance(target.transform.position, this.transform.position) < 1)
                {
                    hit.GetComponent<hit>().perfect();
                    GM.GetComponent<score>().getPoint();
                    GM.GetComponent<score>().getPoint();
                }
                else
                {
                    hit.GetComponent<hit>().good();
                    GM.GetComponent<score>().getPoint();
                }
                

            }
            else
            {
                hit.GetComponent<hit>().miss();
                GM.GetComponent<score>().costPoint();
            }
            
            Debug.Log(button_name);
        }
        if (Input.GetKey(button_name))
        {
            this.GetComponent<Renderer>().material.color = Color.black;
            
        }
        else
        {
            this.GetComponent<Renderer>().material.color = Color.white;
        }
        target = null;
    }

}
