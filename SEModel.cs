using UnityEngine;
using System;

public class SEModel : MonoBehaviour
{
    public int DefaultVolume = 5;
    public float _SEvolume = 0.5f;
    private float _Changevolume = 0.1f;
    private int _magnification = 10;
    [SerializeField] AudioSource _SEAudioSource;

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
        if (_SEvolume < 1)
        {
            _SEvolume += _Changevolume;
            ChangeVolume();
            PlaySound();
            VolumeUp(_SEvolume * _magnification);
        }
    }

    //�{�����[����������
    public void SEVoluemeDown()
    {
        if (_SEvolume > 0)
        {
            _SEvolume -= _Changevolume;
            ChangeVolume();
            PlaySound();
            VolumeDown(_SEvolume * _magnification);
        }
    }

    //�{�����[���̕ύX
    void ChangeVolume()
    {
        _SEAudioSource.volume = _SEvolume;
    }

    void PlaySound()
    {
        _SEAudioSource.Play();
    }
}
