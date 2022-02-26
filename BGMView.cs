using UnityEngine;
using UnityEngine.UI;

public class BGMView : MonoBehaviour
{
    [SerializeField] Image[] _BGMPointImgs = new Image[10];


    //スライダーの位置変える
    public void Volume(float Volume)
    {
        for (int i = 0; i < _BGMPointImgs.Length; i++)
        {
            if ((int)Volume > i)
            {
                IconOpacity(_BGMPointImgs[i]);
            }
            else
            {
                IconTransparent(_BGMPointImgs[i]);
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
