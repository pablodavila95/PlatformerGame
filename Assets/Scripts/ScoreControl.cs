using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{

    public GameObject instruction;
    private int score;
    private float heldTime = 0.0f;

    void Start()
    {
        Text footext = instruction.GetComponent<Text>();
        score = 0;
        FixedChange();
    }

    void Update()
    {
        heldTime += Time.deltaTime*10;
        if (heldTime>=1 )
        {
            score += (int)heldTime;
            heldTime -= (int)heldTime;

        }
        FixedChange();
    }
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        FixedChange();
    }

    void FixedChange()
    {
        Text footext = instruction.GetComponent<Text>();
        footext.text = "Score: " + score;
    }

    public void resetScore()
    {
        Start();
    }
}