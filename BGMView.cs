using UnityEngine;
using UnityEngine.UI;

public class BGMView : MonoBehaviour
{
    [SerializeField] Slider _BGMVolumeSlider;
    
    //スライダーの位置変える
    public void Volume(float Volume)
    {
        _BGMVolumeSlider.value = Volume;
    }
}
