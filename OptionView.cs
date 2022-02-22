using UnityEngine;
using UnityEngine.UI;

public class OptionView : MonoBehaviour
{
    [SerializeField] Image[] _OptionMenuImgs = new Image[3];
    [SerializeField] Image _OptionImgs;

    public void SelectIcon(float selectnum)
    {
        for (int i = 0; i < _OptionMenuImgs.Length; i++)
        {
            if ((int)selectnum == i)
            {
                IconOpacity(_OptionMenuImgs[i]);
            }
            else
            {
                IconTransparent(_OptionMenuImgs[i]);
            }
        }
    }

    private void IconOpacity(Image image)
    {
        image.color = Color.red;
    }

    //“§–¾
    private void IconTransparent(Image image)
    {
        image.color = Color.clear;
    }

    public void OptionMenuActive(bool isOpen)
    {
        _OptionImgs.gameObject.SetActive(isOpen);
    }

}
