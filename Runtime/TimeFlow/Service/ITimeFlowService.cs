using Rossoforge.Services.Service;
using System;

namespace Rossoforge.TimeFlow.Service
{
    public interface ITimeFlowService : IService
    {
        bool IsPaused { get; }

        DateTime GetCurrentUtcTime();
        void PauseTimeFlow();
        void ResumeTimeFlow();
    }
}
