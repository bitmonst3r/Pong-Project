using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

public class Goals : MonoBehaviour
{
    public Paddle paddle1;
    public Paddle paddle2;
    public Score score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if(ball != null)
        {
            ball.transform.position = new Vector3(0f, 1f, 0f);

            if (paddle1)
            {
                score.scorePlayerLeft++;
            }
            if (paddle2)
            {
                score.scorePlayerRight++;
            }
        }
    }
}
