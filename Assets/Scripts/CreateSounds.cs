using System.Collections;
using UnityEngine;

public class CreateSounds : MonoBehaviour
{
    private bool isSpawn;
    public float waitTime = 3f;
    private Coroutine spawn;
    private AudioSource duckAudio;
    private void Start()
    {
        duckAudio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (StartGame.isStart && !isSpawn)
        {
            spawn = StartCoroutine(spawnAudio());
            isSpawn = true;
        }

    }
    IEnumerator spawnAudio()
    {
        while (true)
        {
            if (StartGame.isStart)
            {
                duckAudio.Play();
            }
            else
            {
                StopCoroutine(spawn);
            }
        }
    }
}
