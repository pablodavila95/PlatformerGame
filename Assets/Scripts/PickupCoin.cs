using UnityEngine;
using System.Collections;

public class PickupCoin : MonoBehaviour
{

    public int scoreValue = 100;
    private ScoreControl scoreControl;
    void Start()
    {
        GameObject scoreControlObject = GameObject.FindWithTag("Score");
        if (scoreControlObject != null)
        {
            scoreControl = scoreControlObject.GetComponent<ScoreControl>();
        }
        if (scoreControl == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            Destroy(gameObject);
            scoreControl.AddScore(scoreValue);
    }
}