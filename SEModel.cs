using UnityEngine;
using System;

public class SEModel : MonoBehaviour
{
    public float SEvolume = 0.5f;
    private float _Changevolume = 0.25f;
    [SerializeField] AudioSource _SEAudioSource;

    public event Action<float> VolumeUp;
    public event Action<float> VolumeDown;

    //�{�����[���������l��
    void Start()
    {
        _SEAudioSource.volume = SEvolume;
    }

    //�{�����[�����グ��
    public void SEVoluemeUp()
    {
        if (SEvolume < 1)
        {
            SEvolume += _Changevolume;
        }
        ChangeVolume();
        VolumeUp(SEvolume);
    }

    //�{�����[����������
    public void SEVoluemeDown()
    {
        if (SEvolume > 0)
        {
            SEvolume -= _Changevolume;
        }
        ChangeVolume();
        VolumeDown(SEvolume);
    }

    //�{�����[���̕ύX
    void ChangeVolume()
    {
        _SEAudioSource.volume = SEvolume;
    }
}
