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

    //�{�����[���������l��
    void Start()
    {
        _SEAudioSource.volume = _SEvolume;
    }

    //�{�����[�����グ��
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

    //�{�����[����������
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

    //�{�����[���̕ύX
    void ChangeVolume()
    {
        _SEAudioSource.volume = _SEvolume;
    }

}
