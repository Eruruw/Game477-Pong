using TMPro;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public GameObject uiStart;
    public GameObject uiGameOver;
    public TextMeshProUGUI Player1;
    public TextMeshProUGUI Player2;

    public int leftScore;
    public int rightScore;

    private void Awake()
    {
        uiStart.SetActive(true);
        uiGameOver.SetActive(false);
    }

    void Start()
    {
        leftScore = rightScore = 0;
        Player1.text = "0";
        Player2.text = "0";
    }

    public void Begin()
    {
        uiStart.SetActive(false);
    }

    public void Restart()
    {
        uiGameOver.SetActive(false);
        Start();
    }

    public void ScoreLeft()
    {
        leftScore++;
    }

    public void ScoreRight()
    {
        rightScore++;
    }
}