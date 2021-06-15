using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power : MonoBehaviour
{

     private GameObject player;
     private GameObject powerup;

    public spawnObstacle incr;
        

    private float Timer=5f;

    // Start is called before the first frame update

    void Start()
    {
         player =GameObject.FindGameObjectWithTag("player");
         powerup=GameObject.FindGameObjectWithTag("power");

            
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag=="player"){
             StartCoroutine(fade());
                   
            Destroy(powerup.gameObject);
        }

    }
     private IEnumerator fade(){

            incr.timeBetweenSpawn=2;
            
             yield return new WaitForSeconds(5);
           
            incr.timeBetweenSpawn=1;
                
                
     }
    

    

    
}
