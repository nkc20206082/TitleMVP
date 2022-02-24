using UnityEngine;
using UnityEngine.UI;

public class OptionView : MonoBehaviour
{
    [SerializeField] Image[] _OptionMenuImgs = new Image[3];
    [SerializeField] Image _OptionImgs;

    //選ばれているか、いないか
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

    //不透明
    private void IconOpacity(Image image)
    {
        image.color = Color.red;
    }

    //透明
    private void IconTransparent(Image image)
    {
        image.color = Color.clear;
    }

    //オプションメニューを開く
    public void OptionMenuActive(bool isOpen)
    {
        _OptionImgs.gameObject.SetActive(isOpen);
    }

}
