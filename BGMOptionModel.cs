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

    //�{�����[���������l��
    void Start()
    {
        _BGMAudioSource.volume = _BGMvolume;
    }

    //�{�����[�����グ��
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

    //�{�����[����������
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

    //�{�����[���̕ύX
    void ChangeVolume()
    {
        _BGMAudioSource.volume = _BGMvolume;
    }
}
