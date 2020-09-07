using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{  
    public Vector3 initialImpulse;

    // Start is called before the first frame update
    void Start()
    {
        // Creates initial push
        GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        gameObject.GetComponent<MeshRenderer>().material.color = NewColor(); //ball changes color everytime it hits cube
    }

    private Color NewColor()
    {
        Color color = new Color(UnityEngine.Random.value,
            UnityEngine.Random.value,
            UnityEngine.Random.value);
        return color;
    }
}
