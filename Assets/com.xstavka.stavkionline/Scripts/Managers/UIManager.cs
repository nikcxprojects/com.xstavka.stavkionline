using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance 
    { 
        get => FindObjectOfType<UIManager>(); 
    }

    private GameObject _gameRef;

    [SerializeField] GameObject menu;
    [SerializeField] GameObject game;
    [SerializeField] GameObject achievements;
    [SerializeField] GameObject settings;
    [SerializeField] GameObject pause;

    [Space(10)]
    [SerializeField] GameObject landOther;


    [Space(10)]
    [SerializeField] AudioSource sfxSource;

    private void Awake()
    {
        Obstacle.OnCollided += () =>
        {
            sfxSource.Play();
            StartGame();
        };
    }


    private void Start()
    {
        OpenMenu();
    }

    public void Pause(bool IsPause)
    {
        pause.SetActive(IsPause);
    }

    public void OpenSettings()
    {
        menu.SetActive(false);
        settings.SetActive(true);
    }

    public void OpenAchievements()
    {
        achievements.SetActive(true);
        menu.SetActive(false);
    }

    public void StartGame()
    {
        if (_gameRef)
        {
            Destroy(_gameRef);
        }

        landOther.SetActive(false);

        var _parent = GameObject.Find("Environment").transform;
        var _prefab = Resources.Load<GameObject>("level");

        _gameRef = Instantiate(_prefab, _parent);

        pause.SetActive(false);
        menu.SetActive(false);
        game.SetActive(true);
    }

    public void OpenMenu()
    {
        if(_gameRef)
        {
            Destroy(_gameRef);
        }

        landOther.SetActive(true);

        pause.SetActive(false);
        settings.SetActive(false);
        achievements.SetActive(false);
        game.SetActive(false);
        menu.SetActive(true);
    }
}
