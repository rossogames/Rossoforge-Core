using Rossoforge.Core.Services;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rossoforge.Core.Scenes
{
    public interface ISceneService : IService
    {
        string CurrentSceneName { get; }
        bool IsTransitionRunning { get; }

        Awaitable ChangeScene(string sceneName, Func<Awaitable> onScreenCoveredAsync = null);
        Awaitable ChangeScene(string sceneName, ISceneTransitionData sceneTransitionData, Func<Awaitable> onScreenCoveredAsync = null);
        Awaitable GoBackScene(Func<Awaitable> onScreenCoveredAsync = null);
        Awaitable GoBackScene(ISceneTransitionData sceneTransitionData, Func<Awaitable> onScreenCoveredAsync = null);
        Awaitable RestartScene(Func<Awaitable> onScreenCoveredAsync = null);
        Awaitable RestartScene(ISceneTransitionData sceneTransitionData, Func<Awaitable> onScreenCoveredAsync = null);
        Awaitable LoadSceneAsync(string sceneName, LoadSceneMode mode);
        Awaitable UnloadSceneAsync(string sceneName);
    }
}