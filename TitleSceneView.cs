using UnityEngine;
using UnityEngine.UI;
using System;

public class TitleSceneView : MonoBehaviour
{
    [SerializeField] Image[] _TitleImgs=new Image[3];

    //0,1,2‚Ì‚Ç‚ê‚ª‘I‘ð‚³‚ê‚Ä‚¢‚é‚©
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
                _Opacity(_TitleImgs[i]);
            }
            else
            {
                _Transparent(_TitleImgs[i]);
            }
        }

    }

    //•s“§–¾
    private void _Opacity(Image image)
    {
        image.color = Color.white;
    }

    //“§–¾
    private void _Transparent(Image image)
    {
        image.color = Color.clear;
    }

}
