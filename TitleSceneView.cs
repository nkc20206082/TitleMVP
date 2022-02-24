using UnityEngine;
using UnityEngine.UI;

public class TitleSceneView : MonoBehaviour
{
    [SerializeField] Image[] _TitleImgs=new Image[3];

    //‘I‘ð‚³‚ê‚Ä‚é‚à‚Ì
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

    //•s“§–¾
    private void IconOpacity(Image image)
    {
        image.color = Color.white;
    }

    //“§–¾
    private void IconTransparent(Image image)
    {
        image.color = Color.clear;
    }

}
