using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace SceneManager
{
    public class SceneInstaller : MonoInstaller<SceneInstaller>
    {
        [SerializeField]
        private SceneManager sceneManager;

        public override void InstallBindings()
        {
            Container.Bind<SceneManager>()
                .FromComponentInNewPrefab(sceneManager)
                .WithGameObjectName("SceneManager")
                .AsSingle();

            Container.BindFactory<Object, SceneBase, SceneBase.Factory>()
                .FromFactory<SceneBaseFactory>();
        }
    }
}