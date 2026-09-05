using Rossoforge.Scenes.DataConfig;
using Rossoforge.Services.Service;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rossoforge.Scenes.Service
{
    public interface ISceneService : IService
    {
        string CurrentSceneName { get; }
        bool IsTransitionRunning { get; }

        Awaitable ChangeScene(string sceneName, Func<Awaitable> onScreenCoveredAsync = null);
        Awaitable ChangeScene(string sceneName, ISceneTransitionDataConfig sceneTransitionData, Func<Awaitable> onScreenCoveredAsync = null);
        Awaitable GoBackScene(Func<Awaitable> onScreenCoveredAsync = null);
        Awaitable GoBackScene(ISceneTransitionDataConfig sceneTransitionData, Func<Awaitable> onScreenCoveredAsync = null);
        Awaitable RestartScene(Func<Awaitable> onScreenCoveredAsync = null);
        Awaitable RestartScene(ISceneTransitionDataConfig sceneTransitionData, Func<Awaitable> onScreenCoveredAsync = null);
        Awaitable LoadSceneAsync(string sceneName, LoadSceneMode mode);
        Awaitable UnloadSceneAsync(string sceneName);
    }
}