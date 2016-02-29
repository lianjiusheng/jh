using UnityEngine;
using System.Collections;

namespace MGame.Base
{
	public abstract class Singleton<T> where T : Singleton<T>, new()
	{
		private static T _instance = new T ();
		protected Singleton ()
		{
		}

		public static T Instance {
			get {                
				return _instance;
			}   
		}
	}
}
