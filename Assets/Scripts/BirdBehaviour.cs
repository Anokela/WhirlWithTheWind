using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{

     public Vector3 pos1 = new Vector3(-1,-2,0);
     public Vector3 pos2 = new Vector3(1,0,0);
     public float speed = 1.0f;
    
    void Update() {
         transform.position = Vector3.Lerp (pos1, pos2, Mathf.PingPong(Time.time*speed, 1.0f));
             if (transform.position = pos2)
             {
               SpriteRenderer.flipX;
               }
                if (transform.position = pos1)
             {
               SpriteRenderer.flipX;
               }
               
     }
}
