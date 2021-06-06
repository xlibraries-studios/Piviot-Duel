using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightPlayer : MonoBehaviour
{
    public ParticleSystem particle;
    private new Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
        particle.Pause();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DarkObstacle"))
        {
            Debug.Log("GameOver");
            StartCoroutine(Destroy());
        }
        if (collision.gameObject.CompareTag("LightObstacle"))
        {
            Invoke("Score", 0.5f);
        }
        Debug.Log(DarkPlayer.score);
    }

    private void Score()
    {
        DarkPlayer.score++;
    }

    public IEnumerator Destroy()
    {
        renderer.enabled = false;
        particle.Play();
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(0);
        DarkPlayer.score -= 2;
    }
}
