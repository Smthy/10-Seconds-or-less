using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointGain : MonoBehaviour
{
    public Text scoreText;
    public static int score;

    void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("point"))
        {
            Debug.Log("HIT");

            if (other.gameObject.name == "10Points(Clone)")
            {
                score += 10;
                scoreText.text = "Score : " + score.ToString();
            }
            else if(other.gameObject.name == "50Points(Clone)")
            {
                score += 50;
                scoreText.text = "Score : " + score.ToString();
            }
            else if(other.gameObject.name == "100Points(Clone)")
            {
                score += 100;
                scoreText.text = "Score : " + score.ToString();
            }
            else if(other.gameObject.name == "500Points(Clone)")
            {
                score += 500;
                scoreText.text = "Score : " + score.ToString();
            }
            else
            {
                Debug.Log("Error");
            }
        }         
    }


}
    
