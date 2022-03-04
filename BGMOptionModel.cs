using UnityEngine;
using System;

public class BGMOptionModel : MonoBehaviour
{
    public int DefaultVolume = 5;
    private float _BGMvolume=5f;
    private float _Changevolume=1f; 
    [SerializeField]private AudioSource _BGMAudioSource;

    public event Action<float> SelectSEEvent;
    public event Action<float> VolumeUp;
    public event Action<float> VolumeDown;

    //ボリュームを初期値に
    void Start()
    {
        _BGMAudioSource.volume = _BGMvolume;
    }

    //ボリュームを上げる
    public void BGMVoluemeUp()
    {
        if (_BGMvolume < 10)
        {
            _BGMvolume += _Changevolume;
        ChangeVolume();
        VolumeUp(_BGMvolume);
        SelectSEEvent(_BGMvolume);
        }
    }

    //ボリュームを下げる
    public void BGMVoluemeDown()
    {
        if (_BGMvolume > 0)
        {
            _BGMvolume -= _Changevolume;
        ChangeVolume();
        VolumeDown(_BGMvolume);
        SelectSEEvent(_BGMvolume);
        }
    }

    //ボリュームの変更
    void ChangeVolume()
    {
        _BGMAudioSource.volume = _BGMvolume;
    }
}
