using UnityEngine;
using UnityEngine.UI;

public class BGMView : MonoBehaviour
{
    [SerializeField] Slider _BGMVolumeSlider;
    
    //�X���C�_�[�̈ʒu�ς���
    public void Volume(float Volume)
    {
        _BGMVolumeSlider.value = Volume;
    }
}