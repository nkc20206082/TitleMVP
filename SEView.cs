using UnityEngine;
using UnityEngine.UI;

public class SEView : MonoBehaviour
{
    [SerializeField] Slider _SEVolumeSlider;

    //�X���C�_�[�̈ʒu�ς���
    public void Volume(float Volume)
    {
        _SEVolumeSlider.value = Volume;
    }
}
