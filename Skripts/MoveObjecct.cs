using UnityEngine;

public class MoveObjecct : MonoBehaviour
{
    public float speed = 3;

   private void Update () 
   {
    transform.Translate(Vector2.left * speed * Time.deltaTime) ;
   } 
}
