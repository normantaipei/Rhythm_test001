using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoon : MonoBehaviour
{
    
    public GameObject contraler;
    public GameObject target;
    public bool getInToZoon;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, contraler.transform.position) <=3)
        {
            contraler.GetComponent<click>().target = target;
        }
    }
}
