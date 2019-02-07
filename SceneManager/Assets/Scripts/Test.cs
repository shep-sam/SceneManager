using SceneManager;
using UnityEngine;
using Zenject;
using UniRx;

namespace Assets.Scripts
{
    public class Test : MonoBehaviour
    {
        [Inject]
        private SceneManager.SceneManager sManager;

        private void Start()
        {
            sManager.Load(Scene.Loading);

            Observable.Timer(System.TimeSpan.FromSeconds(5))
                .Subscribe(_ => {
                    sManager.Load(Scene.Lobby);
                }).AddTo(this);
        }
    }
}
