using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TMP : MonoBehaviour
{
    public TMP_InputField OpA;
    public TMP_InputField OpB;
    public TMP_Text Ans;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddEmUp()

    {
        Ans.text = OpA.text + OpB.text;


    }
}
