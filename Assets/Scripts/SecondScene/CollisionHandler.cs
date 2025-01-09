using Unity.VisualScripting;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] GameMananger gameMananger;

    void Start()
    {
        gameOverCanvas.enabled = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            gameOverCanvas.enabled = true;
            gameMananger.enabled = false;
        }
    }
}
