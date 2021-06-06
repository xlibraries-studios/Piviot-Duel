using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RingHolderMovement : MonoBehaviour
{
    public float rotateSpeed = 5.0f;

    private int count = -1;

    public ParticleSystem lightParticle;
    public ParticleSystem darkParticle;

    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {

        if (lightParticle.isPlaying || darkParticle.isPlaying)
        {

        }

        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (count == -1 || count == 1)
                {
                    count = 0;
                }
                else if (count == 0)
                {
                    count = 1;
                }
            }

            if (count == 0)
            {
                RotateClockWise();
            }
            else if (count == 1)
            {
                RotateAntiClockWise();
            }
        }

        scoreText.text = "Score:" + DarkPlayer.score.ToString();
    }

    private void RotateClockWise()
    {
        this.transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }
    private void RotateAntiClockWise()
    {
        this.transform.Rotate(Vector3.back * rotateSpeed * Time.deltaTime);
    }
}
