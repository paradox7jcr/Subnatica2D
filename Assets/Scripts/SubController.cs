using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubController : MonoBehaviour
{
    public float SubSpeed = 5.0f;
    public Vector3 StartPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        this.StartPosition = this.gameObject.transform.position;
        Vector3 deltaPosition = new Vector3();
        if (Input.GetKey(KeyCode.UpArrow))
        {
            deltaPosition.y += SubSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            deltaPosition.y -= SubSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            deltaPosition.x += SubSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            deltaPosition.x -= SubSpeed;
        }
        this.gameObject.transform.position = Vector3.Lerp(this.StartPosition, this.StartPosition + deltaPosition, Time.deltaTime);
    }
}
