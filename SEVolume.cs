using UnityEngine;
using UnityEngine.UI;

public class SEVolume : MonoBehaviour
{
    AudioSource m_AudioSource;

    public Slider m_Slider;

    public bool m_ToggleChange;
    void Start()
    {
        m_AudioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        m_AudioSource.volume = m_Slider.GetComponent<Slider>().normalizedValue;
        //Debug.Log(m_AudioSource.volume);
    }
}
