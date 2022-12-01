using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    public Animator door;
    public GameObject openText;
    private bool comReach;
    // Start is called before the first frame update
    void Start()
    {
        comReach = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Reach")
        {
            comReach = true;
            openText.SetActive(true);
        }   
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Reach")
        {
            comReach = false;
            openText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(comReach && Input.GetButtonDown("Interagir"))
        {
            DoorOpens();
        }
        else
        {
            DoorCloses();
        }
    }

    void DoorOpens()
    {
        Debug.Log("Esta aberto");
        door.SetBool("open", true);
        door.SetBool("closed",false);
    }

    void DoorCloses()
    {
        Debug.Log("Esta Fechado");
        door.SetBool("open", false);
        door.SetBool("closed", true);
    }
}
