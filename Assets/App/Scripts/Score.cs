using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _scoreText;
    [SerializeField] int _score;
    void Start()
    {
        UpdateUI();
    }
    public void PlusScore(int score)
    {
        _score += score;
        UpdateUI();
    }
    public void SetScore(int score)
    {
        _score = score;
        UpdateUI();
    }
    void UpdateUI()
    {
        _scoreText.text = $"{_score.ToString()}";
    }
}
