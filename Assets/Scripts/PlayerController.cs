using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public MotoMove motoMove;
    public float boost;




    // Start is called before the first frame update
    void Start()
    {
        boost = 100;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0,-0.9f,0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0.9f, 0));
        }

        if (Input.GetKey(KeyCode.Z) & boost > 0)
        {
            motoMove.motoSpeed = 30;
            boost = boost - Time.deltaTime*10;
            if(boost < 0)
            {
                boost = 0;
            }
        }
        else
        {
            motoMove.motoSpeed = 20;
        }

        

    }


}
