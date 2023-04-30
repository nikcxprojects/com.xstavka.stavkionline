using UnityEngine.UI;
using UnityEngine;

public class LevelCount : MonoBehaviour
{
    private const string key = "levelcount";
    private Text TextComponent { get; set; }

    private int Count
    {
        get => PlayerPrefs.GetInt(key, 1);
        set => PlayerPrefs.SetInt(key, value);
    }

    private void Awake()
    {
        TextComponent = GetComponent<Text>();

        Goal.OnColided += () =>
        {
            if(SettingsManager.VibraEnbled)
            {
                Handheld.Vibrate();
            }

            TextComponent.text = $"lvl {++Count}";
            UIManager.Instance.StartGame();
        };

        TextComponent.text = $"lvl {Count}";
    }
}
