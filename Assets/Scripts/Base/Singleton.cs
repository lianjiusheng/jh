using UnityEngine;
using System.Collections;

namespace MGame.Base
{
    public abstract class Singleton<T> where T : class, new()
    {
        protected Singleton():
        public static T Instance { get; }
    }
}
