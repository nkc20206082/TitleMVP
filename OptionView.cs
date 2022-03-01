using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class OptionView : MonoBehaviour
{
    [SerializeField] Image[] _OptionMenuImgs = new Image[3];
    [SerializeField] Image _OptionPanel;
    [SerializeField] Image _OptionImgs;

    //選ばれているか、いないか
    public void OptionSelectIcon(float selectnum)
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

    //public void SelectSE(float selectnum)
    //{
    //    SEManager.AudioPlayOneShot("セレクト1", 0);
    //}

    //不透明
    private void IconOpacity(Image image)
    {
        image.color = Color.white;
    }

    //透明
    private void IconTransparent(Image image)
    {
        image.color = Color.clear;
    }

    //オプションメニューを開く
    public void OptionMenuActive(bool isOpen)
    {
        //Debug.Log(isOpen);
        if (isOpen)
        {
            DecisionSE();
            _OptionPanel.DOFade(0.7F, 0.2f);
            _OptionImgs.transform.DOScale(new Vector3(1, 1, 1), 0.2f);
        }
        else
        {
            ReturnSE();
            _OptionImgs.transform.DOScale(new Vector3(0, 0, 0), 0.2f);
            _OptionPanel.DOFade(0.0F, 0.2f);
        }
    }

    private void DecisionSE()
    {
        SEManager.AudioPlayOneShot("決定1", 0);
    }

private void ReturnSE()
    {
        SEManager.AudioPlayOneShot("キャンセル1", 0);
    }
}
