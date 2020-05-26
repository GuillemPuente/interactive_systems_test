using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_camera : MonoBehaviour
{

    public string turn = "no";

    private bool trigger_contact = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -90, 0));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tocando");
        if (other.gameObject.CompareTag("Right"))
        {
            Debug.Log("Giro derecha");
            transform.Rotate(new Vector3(0, 90, 0));
            //transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, 90, 0), Time.deltaTime * tspeed);
            turn = "right";
        }

        else if (other.gameObject.CompareTag("Left"))
        {
            Debug.Log("Giro izquierda");
            transform.Rotate(new Vector3(0, -90, 0));
            //transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, -90, 0), Time.deltaTime * tspeed);
            turn = "left";
        }
        

        if (other.gameObject.CompareTag("Shelter") && !trigger_contact)
        {
            Debug.Log("Stop");
        }
    }
}
