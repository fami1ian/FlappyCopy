using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Pipe : MonoBehaviour
{
   
   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.TryGetComponent<Player1>(out _ ))
      {
         ScoreManager.Instance.SetScore(1);
      }
   }
}
