using UnityEngine;
using System;

public class BGMModel : MonoBehaviour
{
    public float BGMvolume=0.5f;
    private float _Changevolume=0.25f;
    [SerializeField] AudioSource _BGMAudioSource;

    public event Action<float> VolumeUp;
    public event Action<float> VolumeDown;

    //�{�����[���������l��
    void Start()
    {
        _BGMAudioSource.volume = BGMvolume;
    }

    //�{�����[�����グ��
    public void BGMVoluemeUp()
    {
        if (BGMvolume<1)
        {
            BGMvolume += _Changevolume;
        }
        ChangeVolume();
        VolumeUp(BGMvolume);
    }

    //�{�����[����������
    public void BGMVoluemeDown()
    {
        if (BGMvolume > 0)
        {
            BGMvolume -= _Changevolume;
        }
        ChangeVolume();
        VolumeDown(BGMvolume);
    }

    //�{�����[���̕ύX
    void ChangeVolume()
    {
        _BGMAudioSource.volume = BGMvolume;
    }
}
