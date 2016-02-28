using UnityEngine;
using System.Collections;
using MGame.Event;

namespace MGame.UIController
{
    public class UIController : MonoBehaviour
    {

        public uint PanelKey { get; set; }
        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <returns></returns>
        public virtual bool Init()
        {
            this.Reset();
            return true;
        }

        public virtual bool Breathe()
        {
            return true;
        }

        /// <summary>
        /// 显示界面
        /// </summary>
        public virtual void Show()
        {
            gameObject.SetActive(true);
            MEventManager.Instance.SendEvent(MEvent.UI_OnShow, this);
        }

        /// <summary>
        /// 关闭界面
        /// </summary>
        public virtual void Hide()
        {
            gameObject.SetActive(false);
            MEventManager.Instance.SendEvent(MEvent.UI_OnHide, this);
        }

        public virtual void Toggle()
        {
            if (gameObject.activeSelf)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

      
        /// <summary>
        /// 重置界面
        /// </summary>
        public virtual void Reset()
        {
        }

        /// <summary>
        /// 往界面填充数据
        /// </summary>
        /// <param name="data"></param>
        public virtual void fillData(params object[] data)
        {
        }

    }
}