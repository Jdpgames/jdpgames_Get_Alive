using UnityEngine;

namespace ioc.getAlive.Core
{
    /// <summary>
    /// Singleton pattern.
    /// </summary>
    /// <typeparam name="T">Instantiation type of this singleton </typeparam>
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        protected static T _instance;


        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<T>();
                    if (_instance == null)
                    {
                        GameObject obj = new GameObject();
                        _instance = obj.AddComponent<T>();
                    }
                }
                return _instance;

            }
        }


        /// </summary>
        protected virtual void Awake()
        {
            if (!Application.isPlaying)
            {
                return;
            }

            _instance = this as T;
        }
    }

}
