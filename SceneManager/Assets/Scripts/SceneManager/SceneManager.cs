using System.Collections.Generic;
using UnityEngine;
using Zenject;
using UniRx;

namespace SceneManager
{
    public class SceneManager : MonoBehaviour
    {
        [SerializeField]
        private List<SceneBase> scenes;

        private SceneBase.Factory sceneFactory;

        [Inject]
        public void Initialize(SceneBase.Factory sceneFactory)
        {
            this.sceneFactory = sceneFactory;
        }

        public void Load(Scene sceneType)
        {
            var scene = scenes.Find(x => x.SceneType == sceneType);

            sceneFactory.Create(scene);
        }
    }
}
