using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TitleSceneView : MonoBehaviour
{
    [SerializeField] Image[] _TitleImgs=new Image[3];


    //選択されてるもの
    public void SelectIcon(float selectnum)
    {
        //switch (selectnum)
        //{
        //    case 0:
        //        _TitleImgs[0].SetOpacity();
        //        _TitleImgs[1].OutOpacity();
        //        _TitleImgs[2].OutOpacity();
        //        break;
        //    case 1:
        //        _TitleImgs[0].OutOpacity();
        //        _TitleImgs[1].SetOpacity();
        //        _TitleImgs[2].OutOpacity();
        //        break;
        //    case 2:
        //        _TitleImgs[0].OutOpacity();
        //        _TitleImgs[1].OutOpacity();
        //        _TitleImgs[2].SetOpacity();
        //        break;
        //}
        for (int i = 0; i < _TitleImgs.Length; i++)
        {
            if((int)selectnum == i)
            {
                IconOpacity(_TitleImgs[i]);
            }
            else
            {
                IconTransparent(_TitleImgs[i]);
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
        image.color = Color.black;
        image.DOFillAmount(1, 0.3f);
        //image.DOFade(0.0f, 1f).SetEase(Ease.InCubic).SetLoops(-1, LoopType.Yoyo);
    }

    //透明
    private void IconTransparent(Image image)
    {
        image.DOKill();
        image.fillAmount = 0;
        image.color=Color.clear;
    }
}
