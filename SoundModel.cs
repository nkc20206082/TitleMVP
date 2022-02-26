using UnityEngine;
using System;

public class SoundModel : MonoBehaviour
{
    public int selectnum = 0;
    private const int _MAX_ELEMENT = 2;


    public event Action<float> SelectEvent;
    public event Action<bool> SoundSelected;

    //�I�v�V�����̓��e
    public enum SelectStatus : int
    {
        BGM = 0,
        SE = 1
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
        selectnum = 0;
        SelectEvent(selectnum);
        SoundSelected(true);
    }

    public void Escape()
    {
        SoundSelected(false);
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
        }
        return default;
    }
}
