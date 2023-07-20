
using System.Collections;
using UnityEngine;

public class CreateKnife : MonoBehaviour
{
    public GameObject knife;
    private bool isSpawn;
    public float waitTime = 1f;
    private Coroutine spawn;
    private void Update()
    {
        if(StartGame.isStart && !isSpawn)
        {
            spawn = StartCoroutine(spawnKnifes());
            isSpawn = true;
        }
            
    }
    IEnumerator spawnKnifes() 
    {
        while (true)
        {
            if(StartGame.isStart)
            {
                Instantiate(
                knife,
                new Vector2(5.77f, Random.RandomRange(-2.95f, 1.83f)),
                Quaternion.Euler(new Vector3(0, 0, 90f)
                ));
                yield return new WaitForSeconds(waitTime);
            }
            else
            {
                StopCoroutine(spawn);
            }
        }
    }
}
