using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameOver : MonoBehaviour
{
    [SerializeField] ScoreBord scoreBord;

    void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.CompareTag("First") && isOk == false)
        // {
        //     Debug.Log("Collided");
        //     timer = Time.time + .5f;
        //     isOk = true;
        // }

        // if (other.CompareTag("Second") && isOk == true)
        // {
        //     isOk = false;
        //     Debug.Log("Seccess");
        // }

        if(other.CompareTag("Trigger") && other.gameObject.transform.position.y < transform.position.y)
        {
            scoreBord.IncreaseScore(10);
            Destroy(other.transform.parent.transform.parent.gameObject,.5f);
        }
    }
}
