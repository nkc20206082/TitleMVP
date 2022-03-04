using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class OptionView : MonoBehaviour
{
    [SerializeField] private Image[] _optionMenuImgs = new Image[3];
    [SerializeField] private Image _optionPanel;
    [SerializeField] private Image _optionImgs;

    //�I�΂�Ă��邩�A���Ȃ���
    public void OptionSelectIcon(float selectnum)
    {
        for (int i = 0; i < _optionMenuImgs.Length; i++)
        {
            if ((int)selectnum == i)
            {
                IconOpacity(_optionMenuImgs[i]);
            }
            else
            {
                IconTransparent(_optionMenuImgs[i]);
            }
        }
    }

    public void SelectSE(float selectnum)
    {
        SEManager.AudioPlayOneShot("�Z���N�g1", 0);
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
        if (isOpen)
        {
            DecisionSE();
            _optionPanel.DOFade(0.7f, 0.2f);
            _optionImgs.transform.DOScale(new Vector3(1.0f, 1.0f, 1.0f), 0.2f);
        }
        else
        {
            Debug.Log(isOpen);

            ReturnSE();
            _optionImgs.transform.DOScale(new Vector3(0.0f, 0.0f, 0.0f), 0.2f);
            _optionPanel.DOFade(0.0f, 0.2f);
        }
    }

    private void DecisionSE()
    {
        SEManager.AudioPlayOneShot("����1", 0);
    }

private void ReturnSE()
    {
        SEManager.AudioPlayOneShot("�L�����Z��1", 0);
    }
}
