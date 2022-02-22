using UnityEngine;
using System;

public class BGMModel : MonoBehaviour
{
    public float BGMvolume=0.5f;
    private float _Changevolume=0.25f;
    [SerializeField] AudioSource _BGMAudioSource;

    public event Action<float> VolumeUp;
    public event Action<float> VolumeDown;


    void Start()
    {
        _BGMAudioSource.volume = BGMvolume;
    }

    public void BGMVoluemeUp()
    {
        BGMvolume += _Changevolume;
        ChangeVolume();
        VolumeUp(BGMvolume);
    }
    
    public void BGMVoluemeDown()
    {
        BGMvolume -=_Changevolume;
        ChangeVolume();
        VolumeDown(BGMvolume);
    }

    void ChangeVolume()
    {
        _BGMAudioSource.volume = BGMvolume;
    }
}
