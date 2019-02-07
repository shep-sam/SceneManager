using UnityEngine;
using Zenject;

namespace SceneManager
{
    public class SceneBase : MonoBehaviour
    {
        [SerializeField]
        private Scene sceneType;

        public Scene SceneType
        {
            get
            {
                return sceneType;
            }
        }

        public class Factory : PlaceholderFactory<Object, SceneBase>
        {
        }
    }

    public class SceneBaseFactory : IFactory<Object, SceneBase>
    {
        private readonly DiContainer container;

        public SceneBaseFactory(DiContainer container)
        {
            this.container = container;
        }

        public SceneBase Create(Object prefab)
        {
            return container.InstantiatePrefabForComponent<SceneBase>(prefab);
        }
    }
}
