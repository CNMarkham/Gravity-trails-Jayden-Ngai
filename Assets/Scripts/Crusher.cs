using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher : MonoBehaviour
{
    public float speed;
    public int maximumXposition;
    public int minimumXposition;


    private void FixedUpdate()
    {
        if (transform.position.x <= minimumXposition || transform.position.x >= maximumXposition)
        {
            speed *= -1;
            print("test");
        }
        float newXPosition = transform.position.x + speed * Time.fixedDeltaTime;
        float newYPosition = transform.position.y;
        Vector2 newPosition = new Vector2(newXPosition, newYPosition);
        transform.position = newPosition;
    }
}
