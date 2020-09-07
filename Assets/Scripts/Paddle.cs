using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paddle : MonoBehaviour
{
    public bool paddle1;
    public bool paddle2;
    public float amplify = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (paddle1)
        {
            transform.Translate(new Vector3(0f, 0f, Input.GetAxis("Vertical")) * amplify * Time.deltaTime);
        } 
        if (paddle2)
        {
            transform.Translate(new Vector3(0f, 0f, Input.GetAxis("Vertical2")) * amplify * Time.deltaTime);
        }
                
    }
}
