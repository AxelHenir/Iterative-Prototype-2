using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;

    private void OnTriggerEnter(Collider collision){
        teleport();
    }

    public void teleport(){
        player.position = respawnPoint.position;
    }

    void Update(){
        if (Input.GetKeyDown("r")){
            Debug.Log("Resetting Car");
            teleport();
        }
    }
}
