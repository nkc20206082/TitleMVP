using UnityEngine;
using UnityEngine.UI;

public class SoundMenuView : MonoBehaviour
{
    [SerializeField] private GameObject _volumeImageObj;
    [SerializeField] private Image[] _volumeSelectImage = new Image[3];

    public void SoundSelectIcon(float selectnum)
    {
        for (int i = 0; i < _volumeSelectImage.Length; i++)
        {
            if ((int)selectnum == i)
            {
                IconOpacityWhite(_volumeSelectImage[i]);
            }
            else
            {
                IconTransparent(_volumeSelectImage[i]);
            }
        }

    }

    public void SelectSE(float selectnum)
    {
        SEManager.AudioPlayOneShot("セレクト1", 0);
    }

    private void IconOpacityWhite(Image image)
    {
        image.color = Color.white;
    }


    private void IconTransparent(Image image)
    {
        image.color = Color.clear;
    }


    public void SoundMenuActive(bool isOpen)
    {
        _volumeImageObj.SetActive(isOpen);

        if (!isOpen)
        { 
            ReturnSE();
        }
        else
        {
            DecisionSE(0);
        }
    }

    public void DecisionSE(int select)
    {
        SEManager.AudioPlayOneShot("決定1", 0);
    }

    private void ReturnSE()
    {
        SEManager.AudioPlayOneShot("キャンセル1", 0);
    }
}
