using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class OptionView : MonoBehaviour
{
    [SerializeField] Image[] _OptionMenuImgs = new Image[3];
    [SerializeField] Image _OptionImgs;

    //�I�΂�Ă��邩�A���Ȃ���
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

    //�I�v�V�������j���[���J��
    public void OptionMenuActive(bool isOpen)
    {
        //Debug.Log(isOpen);
        if (isOpen)
        {
            _OptionImgs.transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        }
        else
        {
            _OptionImgs.transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        }
    }

}
