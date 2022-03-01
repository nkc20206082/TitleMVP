using UnityEngine;
using UnityEngine.UI;

public class SoundView : MonoBehaviour
{
    [SerializeField] GameObject _VolumeImage;
    [SerializeField] Image[] _VolumeSelectImage = new Image[3];

    public void SoundSelectIcon(float selectnum)
    {
        for (int i = 0; i < _VolumeSelectImage.Length; i++)
        {
            if ((int)selectnum == i)
            {
                IconOpacityWhite(_VolumeSelectImage[i]);
            }
            else
            {
                IconTransparent(_VolumeSelectImage[i]);
            }
        }

    }

    //public void SelectSE(float selectnum)
    //{
    //    SEManager.AudioPlayOneShot("セレクト1", 0);
    //}


    private void IconOpacityWhite(Image image)
    {
        image.color = Color.white;
    }


    private void IconTransparent(Image image)
    {
        image.color = Color.clear;
    }

    public void DecisionSE(int select)
    {
        SEManager.AudioPlayOneShot("決定1", 0);
    }

    public void SoundMenuActive(bool isOpen)
    {
        _VolumeImage.SetActive(isOpen);

        if (!isOpen)
        { 
            ReturnSE();
        }
        else
        {
            DecisionSE(0);
        }
    }


    private void ReturnSE()
    {
        SEManager.AudioPlayOneShot("キャンセル1", 0);
    }
}
