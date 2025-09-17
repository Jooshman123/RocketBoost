using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int collectedCount = 0;
    public int totalCollectibles = 4;
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateScoreUI();
    }

    public void AddPoint()
    {
        collectedCount++;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text = collectedCount + "/" + totalCollectibles + " Tires Collected";
    }
}
