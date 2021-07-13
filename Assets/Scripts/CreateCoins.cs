using UnityEngine;
using UnityEngine.UI;

/**
 * 控制金币预制件的创建
 * 金钱数的增加
 * 宝箱的开关
 * 金币数的变化
 */
public class CreateCoins : MonoBehaviour
{
    // 父节点
    [SerializeField] private RectTransform ParentTrans;
    // 开箱图片
    [SerializeField] private GameObject openBox;
    // 关箱动画 
    [SerializeField] private GameObject closedBox;
    // 金币数量文本
    [SerializeField] private Text moneyTxt;

    //根据点击次数生成不同数量的金币预制件
    private int clickCount = 0;
    private int money = 0;

    //按钮点击函数
    public void OnClick()
    {
        //箱子定时开关
        clickCount++;
        if (clickCount > 3)
        {
            clickCount = 3;
        }
        //金钱数改变
        IncreaseMoney();
        BoxAni();
        for (int i = 0; i < clickCount * 5; i++)
        {
            // 隔一段时间生成一个金币
            Invoke(nameof(CreateFlyCoins), i * 0.1f);
        }

        // 设置关箱时间
        var boxTime = clickCount * 5 * 0.1f + 0.2f;
        Invoke(nameof(BoxAni), boxTime);
        // 增加金币
        
    }
    //创建金币预制件函数
    private void CreateFlyCoins()
    {
        Instantiate(Resources.Load("Prefabs/FlyCoins"), ParentTrans);
    }
    //箱子动画函数
    private void BoxAni()
    {
        if (closedBox.activeInHierarchy)
        {
            openBox.SetActive(true);
            closedBox.SetActive(false);
        }
        else
        {
            openBox.SetActive(false);
            closedBox.SetActive(true);
        }
    }
    //计算金币增加的数量
    private void IncreaseMoney()
    {
        money += clickCount * 5;
        moneyTxt.text = "" + money;
    }
}