using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class RingMovement : MonoBehaviour
{
    float speed = 5f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if(transform.position.x < -11f)
        {
            Destroy(gameObject);
        }
    }
}
