using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{

    public float speed = 4f;
    private Vector3 startPosition;

    public GameObject lightObstacle;
    public GameObject darkObstacle;

    public ParticleSystem lightParticle;
    public ParticleSystem darkParticle;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (lightParticle.isPlaying || darkParticle.isPlaying)
        {

        }

        else
        {
            transform.Translate(translation: Vector3.down * speed * Time.deltaTime);
            if (transform.position.y < -11)
            {
                transform.position = startPosition;
                SpawnObstacle();
                Destroy(GameObject.Find("LightObstacle(Clone)"), 2.4f);
                Destroy(GameObject.Find("DarkObstacle(Clone)"), 2.4f);
            }
        }
    }

    private void SpawnObstacle()
    {
        int count = Random.Range(0, 2);
        int obstacleSpwanIndex = Random.Range(0, 4);
        if (count == 0)
        {
            int count2 = Random.Range(0, 10);
            if (count2 == 7)
            {
                if (obstacleSpwanIndex == 0 || obstacleSpwanIndex == 2)
                {
                    int obstacleSpawnIndex2 = obstacleSpwanIndex + 1;
                    Transform spawnPoint2 = transform.GetChild(obstacleSpawnIndex2).transform;
                    Instantiate(darkObstacle, spawnPoint2.position, Quaternion.identity, transform);
                }
                else if (obstacleSpwanIndex == 1 || obstacleSpwanIndex == 3)
                {
                    int obstacleSpawnIndex2 = obstacleSpwanIndex - 1;
                    Transform spawnPoint2 = transform.GetChild(obstacleSpawnIndex2).transform;
                    Instantiate(darkObstacle, spawnPoint2.position, Quaternion.identity, transform);
                }
            }
            Transform spawnPoint = transform.GetChild(obstacleSpwanIndex).transform;
            Instantiate(lightObstacle, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (count == 1)
        {
            int count2 = Random.Range(0, 10);
            if (count2 == 7)
            {
                if (obstacleSpwanIndex == 0 || obstacleSpwanIndex == 2)
                {
                    int obstacleSpawnIndex2 = obstacleSpwanIndex + 1;
                    Transform spawnPoint2 = transform.GetChild(obstacleSpawnIndex2).transform;
                    Instantiate(lightObstacle, spawnPoint2.position, Quaternion.identity, transform);
                }
                else if (obstacleSpwanIndex == 1 || obstacleSpwanIndex == 3)
                {
                    int obstacleSpawnIndex2 = obstacleSpwanIndex - 1;
                    Transform spawnPoint2 = transform.GetChild(obstacleSpawnIndex2).transform;
                    Instantiate(lightObstacle, spawnPoint2.position, Quaternion.identity, transform);
                }
            }
            Transform spawnPoint = transform.GetChild(obstacleSpwanIndex).transform;
            Instantiate(darkObstacle, spawnPoint.position, Quaternion.identity, transform);
        }
    }
}
