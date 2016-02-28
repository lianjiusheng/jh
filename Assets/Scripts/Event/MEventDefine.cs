using UnityEngine;
using System.Collections;
namespace MGame.Event
{
    public enum MEvent
    {
        Begin,

        #region UI公用消息
        UI_ShowMainUI,                  // 显示主要UI
        UI_HideAllUI,                   // 隐藏主要UI
        UI_Show,                        // 显示界面
        UI_Hide,                        // 关闭界面
        UI_Toggle,                      // 显示/关闭界面
        UI_ReqOriginal,                 // 请求原始UI资源

        UI_MuliShow,                    //多对象UI显示
        UI_MuliHide,                    //多对象关闭

        UI_OnOriginal,                  // 原始UI资源准备好
        UI_OnCreated,                   // 界面创建完毕
        UI_OnShow,                      // UI成功显示
        UI_OnHide,                      // UI成功隐藏
        #endregion

        #region region2
        #endregion

        End,
    }
}