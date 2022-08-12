using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField][Range(1,2)]int reduction =1;
    [SerializeField][Range(0f, 4f)]float cooldown = 2f;
    [SerializeField] Transform portal;
    private float timeInPortal =0;

    // Update is called once per frame
    void Update()
    {
    cooldown += Time.deltaTime;    
    }


  private void randomSpawnPosition()
    {
        int randomSpawnPosition = Random.Range(0, 100);
    }


   private void OnCollisionEnter(Collision other)
   {
   Debug.Log("Entering collision with " + other.gameObject.name) ;
   timeInPortal =0 ;

   }

   private void OnCollisionExit(Collision other) 
   {
    Debug.Log("Ending collision with " + other.gameObject.name) ;
   }

   private void OnCollisionStay(Collision other) 
   {
    Debug.Log("Collisioning with " + other.gameObject.name) ;
    timeInPortal += Time.deltaTime;
    if(timeInPortal >=cooldown)
    {
         Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), Random.Range(-10, 11),Random.Range(-10, 11));
    }
   }



   private void OnTriggerEnter(Collider other)
   {
    timeInPortal = 0;   
    Debug.Log("Entering trigger with " + other.gameObject.name);
   if (other.gameObject.CompareTag("RedPortal"))
   {
    if (cooldown >=0.4f)
    {
        if (reduction == 1){
            transform.localScale /=2;
            reduction = 2;
            cooldown = 0;
        }
        else if (reduction == 2)
        {
            transform.localScale *=2;
            reduction =1;
            cooldown = 0;
        }
    }
   } 
   }

   private void OnTriggerExit(Collider other) 
   {
   Debug.Log("Ending trigger with " + other.gameObject.name) ; 
   }

   private void OnTriggerStay(Collider other) 
   {
    Debug.Log("Staying on trigger with " + other.gameObject.name) ;
    
   }

 
}
