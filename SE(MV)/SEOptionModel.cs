using UnityEngine;
using System;

public class SEOptionModel : MonoBehaviour
{
    public int defaultVolume = 5;
    private float _SEvolume = 5f;
    private float _changevolume = 1f;
    [SerializeField] AudioSource _SEAudioSource;

    public event Action<float> SelectSEEvent;
    public event Action<float> VolumeUp;
    public event Action<float> VolumeDown;

    //ボリュームを初期値に
    void Start()
    {
        _SEAudioSource.volume = _SEvolume;
    }

    //ボリュームを上げる
    public void SEVoluemeUp()
    {
        if (_SEvolume < 10)
        {
            _SEvolume += _changevolume;
            ChangeVolume();
            VolumeUp(_SEvolume);
            SelectSEEvent(_SEvolume);
        }
    }

    //ボリュームを下げる
    public void SEVoluemeDown()
    {
        if (_SEvolume > 0)
        {
            _SEvolume -= _changevolume;
            ChangeVolume();
            VolumeDown(_SEvolume);
            SelectSEEvent(_SEvolume);
        }
    }

    //ボリュームの変更
    void ChangeVolume()
    {
        _SEAudioSource.volume = _SEvolume;
    }

}
