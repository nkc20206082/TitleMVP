using UnityEngine;
using UnityEngine.UI;

public class SEView : MonoBehaviour
{
    [SerializeField] Image[] _SEPointImgs = new Image[10];


    //�X���C�_�[�̈ʒu�ς���
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

    //�s����
    private void IconOpacity(Image image)
    {
        image.color = Color.white;
    }

    //����
    private void IconTransparent(Image image)
    {
        image.color = Color.clear;
    }
}
