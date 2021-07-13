using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * 开始按钮点击切换到主视图界面
 */
public class Login : MonoBehaviour
{
    //初始界面
    [SerializeField] private  GameObject loginCanvas;
    //主界面
    [SerializeField] private  GameObject mainCanvas;
    
    public void OnCilck()
    {
        loginCanvas.SetActive(false);
        mainCanvas.SetActive(true);
       
    }
}
