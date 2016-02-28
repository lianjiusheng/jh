using UnityEngine;
using System.Collections;
using MGame.Base;
using System.Collections.Generic;

namespace MGame.Event
{
    public class MEventManager : Singleton<MEventManager>
    {

        public delegate void MEventHandler(MEvent evt, params object[] args);

        private HashSet<MEventHandler>[] m_AllGlobalHandler;

        public MEventManager()
        {
            m_AllGlobalHandler = new HashSet<MEventHandler>[(int)MEvent.End];
            for (int i = 0; i < m_AllGlobalHandler.Length; i++)
            {
                m_AllGlobalHandler[i] = new HashSet<MEventHandler>();
            }
        }

        public void Init()
        {
        }

        public void AddHandler(MEventHandler handler, params MEvent[] events)
        {
            foreach (MEvent e in events)
            {
                m_AllGlobalHandler[(int)e].Add(handler);
            }
        }

        public void DelHandler(MEvent e, MEventHandler handler)
        {
            m_AllGlobalHandler[(int)e].Remove(handler);
        }

        public void ClearHandler(MEvent e)
        {
            m_AllGlobalHandler[(int)e].Clear();
        }

        public void ClearAllHandler()
        {
            for (int i = 0; i < m_AllGlobalHandler.Length; i++)
            {
                this.ClearHandler((MEvent)i);
            }
        }

        public void SendEvent(MEvent e, params object[] args)
        {
            foreach (MEventHandler handler in m_AllGlobalHandler[(int)e])
            {
                handler(e, args);
            }
        }

    }

}