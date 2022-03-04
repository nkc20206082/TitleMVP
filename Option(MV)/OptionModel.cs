using UnityEngine;
using System;

public class OptionModel : MonoBehaviour
{
    public int selectnum = 0;
    private const int _MAX_ELEMENT = 3;


    [SerializeField] private OptionReturn _optionReturn;
    [SerializeField] private VolumeSelect _VolumeSelect;
    [SerializeField] private CreditUISelect _CreditUISelect;

    public event Action<float> SelectSEEvent;
    public event Action<float> SelectEvent;
    public event Action<bool> OptionSelected;

    //�I�v�V�����̓��e
    public enum SelectStatus : int
    {
        RETURN = 0,
        VOLUME = 1,
        CREDIT = 2
    }

    //�O�̍���
    public void GoBack()
    {
        selectnum = (selectnum - 1 + _MAX_ELEMENT) % _MAX_ELEMENT;
        SelectEvent(selectnum);
        SelectSEEvent(selectnum);
    }

    //���̍���
    public void GoNext()
    {
        selectnum = (++selectnum) % _MAX_ELEMENT;
        SelectEvent(selectnum);
        SelectSEEvent(selectnum);
    }


    public void Selected()
    {
        selectnum = 0;
        SelectEvent(selectnum);
        OptionSelected(true);
    }

    //�I�v�V���������
    public void Escape()
    {
        OptionSelected(false);
    }

    //���莞����
    public int DecisionMenu()
    {
        switch (selectnum)
        {
            case (int)SelectStatus.RETURN:
                _optionReturn.Select();
                return (int)SelectStatus.RETURN;

            case (int)SelectStatus.VOLUME:
                _VolumeSelect.Select();
                return (int)SelectStatus.VOLUME;

            case (int)SelectStatus.CREDIT:
                _CreditUISelect.Select();
                return (int)SelectStatus.CREDIT;
        }
        return default;
    }
}
