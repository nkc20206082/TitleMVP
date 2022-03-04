using UnityEngine;
using UnityEngine.UI;

public class BGMOptionView : MonoBehaviour
{
    [SerializeField] Image[] _BGMPointImgs = new Image[10];


    //�X���C�_�[�̈ʒu�ς���
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

    public void SelectSE(float select)
    {
        SEManager.AudioPlayOneShot("�Z���N�g1", 0);
    }

    public void TestBGM(float Volume)
    {
        Debug.Log(Volume);
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
