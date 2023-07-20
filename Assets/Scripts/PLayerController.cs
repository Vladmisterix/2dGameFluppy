using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PLayerController : MonoBehaviour
{
    private Vector3 targetPosition;
    public GameObject player;
    public float speed = 5f;
    private void Update()
    {
        if (StartGame.isStart)
        {
#if UNITY_ANDROID
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    targetPosition = Camera.main.ScreenToWorldPoint(touch.position);
                    Debug.Log(targetPosition);
                }
            }

#endif

#if UNITY_EDITOR
            if (Input.GetMouseButton(0))
            {
                targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
#endif
            float step = speed * Time.deltaTime;

            if (targetPosition.y < -3.58f) 
                targetPosition.y = -3.58f;
            else if(targetPosition.y > 3.36f)
                targetPosition.y = 3.36f;

            player.transform.position = Vector3.MoveTowards(
                player.transform.position,
                new Vector3(targetPosition.x, targetPosition.y, player.transform.position.z),
                step
                );
        }
    }
}
