﻿using System;
using System.Runtime.CompilerServices;
using IPA.Config.Stores;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace OverlySensitiveSpectrograms
{
    internal class Config
    {
#pragma warning disable CS8632
        public event Action<Config>? Updated;
#pragma warning restore CS8632

        public virtual float SampleBoost { get; set; } = 2f;

        public virtual float SampleLerp0 { get; set; } = 16f;
        public virtual float SampleLerp1 { get; set; } = 8f;

        public virtual float PeakOffset { get; set; } = 1.2f;

        public virtual bool UseInstantChangeThreshold { get; set; }
        public virtual float InstantChangeThreshold { get; set; } = .1f;

        public virtual void Changed()
        {
            Updated?.Invoke(this);
        }
    }
}
