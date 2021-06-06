using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DarkPlayer : MonoBehaviour
{
    public ParticleSystem particle;
    private new Renderer renderer;
    public static int score = 0;

    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
        particle.Pause();
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LightObstacle"))
        {
            Debug.Log("GameOver");
            StartCoroutine(Destroy());
        }

        if (collision.gameObject.CompareTag("DarkObstacle"))
        {
            Invoke("Score", 0.5f);
        }
        Debug.Log(score);
    }

    private void Score()
    {
        score++;
    }


    public IEnumerator Destroy()
    {
        renderer.enabled = false;
        particle.Play();
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(0);
        score -= 2;
    }
}
