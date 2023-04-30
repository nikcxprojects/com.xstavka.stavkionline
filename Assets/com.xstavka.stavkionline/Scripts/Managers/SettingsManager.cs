using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [Space(10)]
    [SerializeField] AudioSource musicSource;
    [SerializeField] Image onMusicImg;
    [SerializeField] Image offMusicImg;

    [Space(10)]
    [SerializeField] AudioSource soundSource;
    [SerializeField] Image onSoundImg;
    [SerializeField] Image offSoundImg;

    [Space(10)]
    [SerializeField] Image onVibraImg;
    [SerializeField] Image offVibraImg;

    [Space(10)]
    [SerializeField] Color active;
    [SerializeField] Color disable;
    [SerializeField] Color baseColor;

    public static bool VibraEnbled { get; set; }

    private void Start()
    {
        SetMusicsStatus(true);
        SetSoundsStatus(true);
        SetVibrationStatus(true);
    }

    public void SetMusicsStatus(bool IsEnable)
    {
        musicSource.mute = !IsEnable;

        if (IsEnable)
        {
            onMusicImg.color = active;
            offMusicImg.color = baseColor;
        }
        else
        {
            offMusicImg.color = disable;
            onMusicImg.color = baseColor;
        }
    }

    public void SetSoundsStatus(bool IsEnable)
    {
        soundSource.mute = !IsEnable;

        if(IsEnable)
        {
            onSoundImg.color = active;
            offSoundImg.color = baseColor;
        }
        else
        {
            offSoundImg.color = disable;
            onSoundImg.color = baseColor;
        }
    }

    public void SetVibrationStatus(bool IsEnable)
    {
        VibraEnbled = IsEnable;

        if (IsEnable)
        {
            onVibraImg.color = active;
            offVibraImg.color = baseColor;
        }
        else
        {
            offVibraImg.color = disable;
            onVibraImg.color = baseColor;
        }
    }
}
