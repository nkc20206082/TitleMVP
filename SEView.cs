using UnityEngine;
using UnityEngine.UI;

public class SEView : MonoBehaviour
{
    [SerializeField] Image[] _SEPointImgs = new Image[10];


    //スライダーの位置変える
    public void Volume(float Volume)
    {
        for (int i = 0; i < _SEPointImgs.Length; i++)
        {
            if ((int)Volume > i)
            {
                IconOpacity(_SEPointImgs[i]);
            }
            else
            {
                IconTransparent(_SEPointImgs[i]);
            }
        }
    }

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
}
