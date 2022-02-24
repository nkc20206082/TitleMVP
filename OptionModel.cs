using UnityEngine;
using System;

public class OptionModel : MonoBehaviour
{
    public int selectnum = 0;
    private const int _MAX_ELEMENT = 3;

    //[SerializeField] BGMOperation _BGM;
    //[SerializeField] Option _SE;

    public event Action<float> SelectEvent;
    public event Action<bool> OptionSelected;

    //�I�v�V�����̓��e
    public enum SelectStatus : int
    {
        BGM = 0,
        SE = 1,
        Exit = 2
    }

    //�O�̍���
    public void GoBack()
    {
        selectnum = (selectnum - 1 + _MAX_ELEMENT) % _MAX_ELEMENT;
        SelectEvent(selectnum);
    }

    //���̍���
    public void GoNext()
    {
        selectnum = (++selectnum) % _MAX_ELEMENT;
        SelectEvent(selectnum);
    }

    //�I�v�V�������I�΂ꂽ��
    public void Selected()
    {
        OptionSelected(true);
    }

    //�I�v�V���������
    public void EscapeOption()
    {
        OptionSelected(false);
    }

    //���莞����
    public int DecisionMenu()
    {
        switch (selectnum)
        {
            case (int)SelectStatus.BGM:
                //_BGM.Select();
                return (int)SelectStatus.BGM;

            case (int)SelectStatus.SE:
                //_Option.Select();
                return (int)SelectStatus.SE;

            case (int)SelectStatus.Exit:
                //_Esc.Select();
                selectnum = 0;
                SelectEvent(selectnum);
                EscapeOption();
                return (int)SelectStatus.Exit;
        }
        return default;
    }
}
