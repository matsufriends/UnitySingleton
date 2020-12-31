using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public abstract class SingletonMono<T> : MonoBehaviour where T : SingletonMono<T> {
    private static T sInstance;

    public static T Instance {
        get {
            if (sInstance != null) return sInstance;
            var scene = SceneManager.GetActiveScene();

            var componentsList = new List<T>();

            foreach (var obj in scene.GetRootGameObjects()) {
                var components = obj.GetComponentsInChildren<T>(true);
                if (components.Length != 0) {
                    componentsList.AddRange(components);
                }
            }

            if (componentsList.Count      == 0) Debug.Log($"{typeof(T)}が見つかりません");
            else if (componentsList.Count > 1) Debug.Log($"{typeof(T)}が複数存在します");
            else sInstance = componentsList[0];
            sInstance.OnInstanceMade();
            return sInstance;
        }
    }

    protected virtual void OnInstanceMade() { }
}