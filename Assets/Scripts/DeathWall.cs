using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//dw
public class DeathWall : MonoBehaviour
{
    public Vector3 checkedPoint;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player.GetComponent<CharacterController>().enabled = false; 
            player.transform.position = checkedPoint;
            player.GetComponent<CharacterController>().enabled = true;
        }
    }
}
