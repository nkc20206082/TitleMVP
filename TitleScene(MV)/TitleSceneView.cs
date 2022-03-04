using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TitleSceneView : MonoBehaviour
{
    [SerializeField]private Image[] _titleImgs=new Image[3];


    //選択されてるもの
    public void SelectIcon(float selectnum)
    {
        for (int i = 0; i < _titleImgs.Length; i++)
        {
            if((int)selectnum == i)
            {
                IconOpacity(_titleImgs[i]);
            }
            else
            {
                IconTransparent(_titleImgs[i]);
            }
        }
    }

    public void SelectSE(float selectnum)
    {
        SEManager.AudioPlayOneShot("セレクト1", 0);
    }

    //不透明
    private void IconOpacity(Image image)
    {
        image.color = Color.black;
        image.DOFillAmount(1, 0.3f);
    }

    //透明
    private void IconTransparent(Image image)
    {
        image.DOKill();
        image.fillAmount = 0.0f;
        image.color=Color.clear;
    }
}
