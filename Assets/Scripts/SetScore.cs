using UnityEngine.UI;
using UnityEngine;

public class SetScore : MonoBehaviour
{
    public Text scoreText;
    private short score = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Knife"))
        {
            score++;
            scoreText.text = "—чет: " + score.ToString();

            if(PlayerPrefs.GetInt("score") < score)
                PlayerPrefs.SetInt("score", score);
        }
    }
}
