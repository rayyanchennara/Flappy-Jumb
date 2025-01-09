using TMPro;
using UnityEngine;

public class ScoreBordTwo : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI winCanvasScore;
    [SerializeField] Canvas winCanvas;
    [SerializeField] Canvas defualtCanvas;
    [SerializeField] TextMeshProUGUI gameOverScore;

    [SerializeField] GameMananger gameMananger;
    int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        winCanvas.enabled = false;
        scoreText.text = "Score :- " + score.ToString();
        winCanvasScore.text = "Score :- " + score.ToString();
        gameOverScore.text = "Score :- " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(score >= 20)
        {
            WinCanvasProcess();
        }
    }

    private void WinCanvasProcess()
    {
        winCanvas.enabled = true;
        defualtCanvas.enabled = false;
        gameMananger.enabled = false;
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        scoreText.text = "Score :- " + score.ToString();
        winCanvasScore.text = "Score :- " + score.ToString();
        gameOverScore.text = "Score :- " + score.ToString();
    }
}
