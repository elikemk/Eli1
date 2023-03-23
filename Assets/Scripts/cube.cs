using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*= new Vector3(1f, 0f, 0f); //take the transform and set position to 1, 0 , 0?*/
        //f == float
        //transform.Translate(Vector3.forward); //global
        //transform.Translate(transform.forward); //local

        MeshRenderer x; //get the compenent manipluate the compenent
        x = GetComponent<MeshRenderer>();
        x.material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.01f, 0f, 0f, Space.World);
        transform.Rotate(0, 1f, 0f);
    }
}
