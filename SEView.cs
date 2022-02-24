using UnityEngine;
using UnityEngine.UI;

public class SEView : MonoBehaviour
{
    [SerializeField] Slider _SEVolumeSlider;

    //スライダーの位置変える
    public void Volume(float Volume)
    {
        _SEVolumeSlider.value = Volume;
    }
}
