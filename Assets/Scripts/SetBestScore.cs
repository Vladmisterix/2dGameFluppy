
using UnityEngine.UI;
using UnityEngine;

public class SetBestScore : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Text>().text = "������: " + PlayerPrefs.GetInt("score").ToString();
    }

}
