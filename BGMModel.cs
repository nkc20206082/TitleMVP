using UnityEngine;
using System;

public class BGMModel : MonoBehaviour
{
    public int DefaultVolume = 5;
    float _BGMvolume=0.5f;
    private float _Changevolume=0.1f; 
    private int _magnification = 10;
    [SerializeField] AudioSource _BGMAudioSource;

    //public event Action<float> SelectSEvent;
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
        if (_BGMvolume < 1)
        {
            _BGMvolume += _Changevolume;
        }
        ChangeVolume();
        VolumeUp(_BGMvolume * _magnification);
        //SelectSEEvent(_BGMvolume);
    }

    //ボリュームを下げる
    public void BGMVoluemeDown()
    {
        if (_BGMvolume > 0)
        {
            _BGMvolume -= _Changevolume;
        }
        ChangeVolume();
        VolumeDown(_BGMvolume * _magnification);
        //SelectSEEvent(_BGMvolume);
    }

    //ボリュームの変更
    void ChangeVolume()
    {
        _BGMAudioSource.volume = _BGMvolume;
    }
}
