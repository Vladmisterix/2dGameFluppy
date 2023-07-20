using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject logoText;
    public static bool isStart;
    public GameObject scoreText;

    public float highSpeed = 5f;
    private void Update()
    {
        if(isStart && logoText != null)
        {
            logoText.transform.Translate(Vector2.up * highSpeed * Time.deltaTime);
        }
    }

    public void startGame()
    {
        if(isStart)
        {
            return;
        }

        isStart = true;
        logoText.GetComponent<Animator>().enabled = false;
        Destroy(logoText, 1.5f);

        GetComponent<Animation>().Play("PlayButton");

        scoreText.SetActive(true);
    }
}
