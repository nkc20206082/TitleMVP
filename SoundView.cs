using UnityEngine;
using UnityEngine.UI;

public class SoundView : MonoBehaviour
{
    [SerializeField] Image[] _VolumeImage = new Image[2];
    [SerializeField] Image[] _VolumeSelectImage = new Image[2];

    public void SoundSelectIcon(float selectnum)
    {
        for (int i = 0; i < _VolumeSelectImage.Length; i++)
        {
            if ((int)selectnum == i)
            {
                IconOpacity(_VolumeSelectImage[i]);
            }
            else
            {
                IconTransparent(_VolumeSelectImage[i]);
            }
        }

    }
    private void IconOpacity(Image image)
    {
        image.color = Color.white;
    }

    private void IconTransparent(Image image)
    {
        image.color = Color.clear;
    }


    public void SoundMenuActive(bool isOpen)
    {
        if (isOpen)
        {
            for (int i = 0; i < _VolumeImage.Length; i++)
            {
                _VolumeImage[i].gameObject.SetActive(isOpen);
            }
        }
        else
        {
            for (int i = 0; i < _VolumeImage.Length; i++)
            {
                _VolumeImage[i].gameObject.SetActive(isOpen);
            }
        }

    }

}
