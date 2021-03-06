using UnityEngine;

public class CreditView : MonoBehaviour
{
    [SerializeField]private GameObject _CreditImageObj;


    public void DecisionSE(int select)
    {
        SEManager.AudioPlayOneShot("決定1", 0);
    }

    public void CreditMenuActive(bool isOpen)
    {
        //Debug.Log(isOpen);
        _CreditImageObj.SetActive(isOpen);

        if (!isOpen)
        {
            ReturnSE();
        }
        else
        {
            DecisionSE(0);
        }
    }


    private void ReturnSE()
    {
        SEManager.AudioPlayOneShot("キャンセル1", 0);
    }
}
