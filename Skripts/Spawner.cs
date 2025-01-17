using Unity.Collections;
using UnityEngine;
public class Spawner : MonoBehaviour
{
   public float TimeToSpawn, minYPosition, maxYPosition; 
   public GameObject pipePrefab;
   private float timer; 
   

   private void Update () {
    if (timer<= 0) 
    {
        timer = TimeToSpawn;
        GameObject pipe = Instantiate(pipePrefab, transform.position, Quaternion.identity) ;
        float rand = Random.Range (minYPosition, maxYPosition) ;
        pipe.transform.position = new Vector3 (pipe.transform.position.x, rand, 0) ;
    }
   else
   {
    timer -= Time.deltaTime;
   }
   }
}
