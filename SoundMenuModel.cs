using UnityEngine;
using System;

public class SoundMenuModel : MonoBehaviour
{
    public int selectnum = 0;
    private const int _MAX_ELEMENT = 3;


    public event Action<float> SelectEvent;
    public event Action<float> SelectSEEvent;
    public event Action<bool> SoundSelected;

    //�I�v�V�����̓��e
    public enum SelectStatus : int
    {
        BGM = 0,
        SE = 1,
        RETURN=2
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

    //�{�����[�����I�΂ꂽ��
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
                //DecisionSEEvent((int)SelectStatus.BGM);
                return (int)SelectStatus.BGM;
            case (int)SelectStatus.SE:
                //DecisionSEEvent((int)SelectStatus.SE);
                return (int)SelectStatus.SE;
            case (int)SelectStatus.RETURN:
                Escape();
                return (int)SelectStatus.RETURN;
        }
        return default;
    }
}
