using UnityEngine;
using UnityEngine.UI;

public class BGMView : MonoBehaviour
{
    [SerializeField] Slider _BGMVolumeSlider;
    
    public void Volume(float Volume)
    {
        _BGMVolumeSlider.value = Volume;
    }
}
