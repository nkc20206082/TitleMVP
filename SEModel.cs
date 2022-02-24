using UnityEngine;
using System;

public class SEModel : MonoBehaviour
{
    public float SEvolume = 0.5f;
    private float _Changevolume = 0.25f;
    [SerializeField] AudioSource _SEAudioSource;

    public event Action<float> VolumeUp;
    public event Action<float> VolumeDown;

    //ボリュームを初期値に
    void Start()
    {
        _SEAudioSource.volume = SEvolume;
    }

    //ボリュームを上げる
    public void SEVoluemeUp()
    {
        if (SEvolume < 1)
        {
            SEvolume += _Changevolume;
        }
        ChangeVolume();
        VolumeUp(SEvolume);
    }

    //ボリュームを下げる
    public void SEVoluemeDown()
    {
        if (SEvolume > 0)
        {
            SEvolume -= _Changevolume;
        }
        ChangeVolume();
        VolumeDown(SEvolume);
    }

    //ボリュームの変更
    void ChangeVolume()
    {
        _SEAudioSource.volume = SEvolume;
    }
}
