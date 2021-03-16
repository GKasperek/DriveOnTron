using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoMove : MonoBehaviour
{
    public float motoSpeed;

    public Transform tracker;
    private Vector3 lastPosition;
    private Vector3 actualPosition;

    public GameObject myNeon;

    // Start is called before the first frame update
    void Start()
    {
        lastPosition = tracker.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * motoSpeed);

        actualPosition = tracker.position;
        createNeon(actualPosition, lastPosition);
        lastPosition = actualPosition;
    }

    void createNeon(Vector3 start, Vector3 end)
    {
        // Create object at starting point in direction of end
        //GameObject neon = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject neon = GameObject.Instantiate(myNeon);
        neon.transform.position = start;
        neon.transform.LookAt(end);

        //Calculate distance between start and end
        float dist = Mathf.Sqrt(Mathf.Pow(end.x - start.x, 2) + Mathf.Pow(end.y - start.y, 2));

        neon.transform.localScale = new Vector3(0.5f, 2, dist);
    }
}
