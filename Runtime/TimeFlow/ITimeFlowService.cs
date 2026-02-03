using Rossoforge.Core.Services;
using System;

namespace Rossoforge.Core.TimeFlow
{
    public interface ITimeFlowService : IService
    {
        bool IsPaused { get; }

        DateTime GetCurrentUtcTime();
        void PauseTimeFlow();
        void ResumeTimeFlow();
    }
}
