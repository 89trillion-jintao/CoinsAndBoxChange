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
    private readonly Vector3 endPosition = new Vector3(1.94f, 4.2f, 0);
    private void Start()
    {
        //使用dotween实现移动动画
        flyCoin.transform.DOMove(endPosition, 0.5f);
    }

    private void Update()
    {
        //当到达最终的点时，销毁金币
        if (flyCoin.transform.position==endPosition)
        {
            DestroyCoins();
        }
    }

    private void DestroyCoins()
    {
        //销毁金币函数
        Destroy(flyCoin);
    }
}