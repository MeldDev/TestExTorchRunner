
using UnityEngine;
using UnityEngine.UI;

public class Torch : MonoBehaviour
{
    [SerializeField] private Light _light;
    [SerializeField] private float _fireStrength = 100;
    [SerializeField] private float _fireStrengthMax = 100;
    [SerializeField] private float _fireFading = 5;
    [SerializeField] private Image _fireIMG;
    [SerializeField] private GameState gameState;

    private void Start()
    {
        gameState = FindObjectOfType<GameState>();
    }
    private void UpdateUI()
    {
        _fireIMG.fillAmount = _fireStrength/_fireStrengthMax;
    }
    public void ChangeStrengthTorch(float strength)
    {
        _fireStrength += strength;
        UpdateUI();
    }
    public void PlusStrengthTorch(float strength)
    {
        _fireStrength += strength;
        UpdateUI();
    }
    public void SetStrengthTorch(float strength)
    {
        _fireStrength = strength;
        UpdateUI();
    }
    private void Update()
    {
        ChangeStrengthTorch(_fireFading * Time.deltaTime);
        _light.intensity = _fireStrength;
        if (_fireStrength <= 0)
        {
            gameState.MainMenu();
        }
    }
}
