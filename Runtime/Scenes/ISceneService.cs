using Rossoforge.Core.Services;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rossoforge.Core.Scenes
{
    public interface ISceneService : IService
    {
        bool IsLoading { get; }
        string CurrentSceneName { get; }
        Awaitable ChangeScene(string sceneName);
        Awaitable ChangeScene(string sceneName, ISceneTransitionData sceneTransitionData);
        Awaitable LoadScene(string sceneName, LoadSceneMode loadSceneMode);
        Awaitable UnloadScene(string sceneName);
        Awaitable GoBackScene();
        Awaitable GoBackScene(ISceneTransitionData sceneTransitionData);
        Awaitable RestartScene();
        Awaitable RestartScene(ISceneTransitionData sceneTransitionData);
    }
}