
using UnityEngine;

public class Knife : MonoBehaviour
{
    public float speed = 5f;
    private void Update()
    {
        if (StartGame.isStart)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime, Space.World);

            if(transform.position.x < -4.03f) 
                Destroy(gameObject);
        }
    }
}
