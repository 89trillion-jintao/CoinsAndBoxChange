using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UIElements;
/**
 * 控制金币飞行动画
 */
public class CoinsAni : MonoBehaviour
{
    //金币对象
    [SerializeField] private GameObject flyCoin;
    private bool isCoin=true;
    private void Start()
    {
        if (isCoin)
        {
            //使用DOTween实现移动动画
            flyCoin.transform.DOMove(CreateCoins.GetInstance().endTransform.position, 1f);
        }
    }
    private void Update()
    {
        //当到达最终的点时，销毁金币
        if (Vector3.Distance(flyCoin.transform.position,CreateCoins.GetInstance().endTransform.position)<0.01f)
        {
            CreateCoins.GetInstance().sumOfMoney++;
            Destroy(flyCoin);
            CreateCoins.GetInstance().moneyTxt.text = "" + CreateCoins.GetInstance().sumOfMoney;
        }
    }
}