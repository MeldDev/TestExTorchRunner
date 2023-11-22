using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameState : MonoBehaviour
{
    [SerializeField] GameObject _mainMenuUI;
    [SerializeField] GameObject _gameUI;
    [SerializeField] GameObject _player;
    
    private Score score;
    private Torch torch;
    private SpawnMap spawnMap;


    private void Start()
    {
        score = FindObjectOfType<Score>();
        torch = FindObjectOfType<Torch>();
        spawnMap = FindObjectOfType<SpawnMap>();
        MainMenu();
    }
    public void MainMenu()
    {
        _mainMenuUI.SetActive(true);
        _gameUI.SetActive(false);
        _player.SetActive(false);
    }
    public void StartGame()
    {
        score.SetScore(0);
        torch.SetStrengthTorch(100);
        spawnMap.StartGameMap();
        _mainMenuUI.SetActive(false);
        _gameUI.SetActive(true);
        _player.SetActive(true);
    }
}
