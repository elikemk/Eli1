using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chelsa : MonoBehaviour
{
    float jog = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Animator myAnimator; //create a reference to an Animator component
        myAnimator = GetComponent<Animator>(); //associate the reference with out Animator
        if (Input.GetKeyDown(KeyCode.UpArrow)) //if I press the W key down (one frame
        {
            jog += 0.1f;
            myAnimator.SetFloat("Blend" ,jog);



        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) //if I press the R key down (one frame)
        {
            jog -= 0.1f;
            myAnimator.SetFloat("Blend", jog);

        }
    }
}
