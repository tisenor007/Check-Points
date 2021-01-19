using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 position;
    public bool checkpoint;
    public GameObject checkpointtext;
    
   // public GameObject Player;
    //public GameObject spawn;
   

    // Start is called before the first frame update
    void Start()
    {
        position = new Vector3(0, 1, -14);
        checkpoint = false;
        //Player.transform.position;
        //gameObject.transform.position;
        //transform.position;
        
    }
   
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            checkpointtext.SetActive(true);
            checkpoint = true;
        }
        if (other.gameObject.tag == "KillBox")
        {
            Debug.Log("Triggered!");
            gameObject.transform.position = position;
            //Player.transform.position = spawn.transform.position;
            if (checkpoint == true)
            {
                Debug.Log("Triggered!");
                position = new Vector3(0, 1, 0);
                gameObject.transform.position = position;
            }
        }
        
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            checkpointtext.SetActive(false);
            Destroy(checkpointtext);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
