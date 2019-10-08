﻿using Gym.Environments.Envs.Classic;
using Gym.Envs;
using Gym.Rendering.Avalonia;
using ReinforcementLearning.GameConfigurations;

namespace ReinforcementLearning.Runner
{
    public sealed class CartPoleConfiguration : IGameConfiguration
    {
        public IEnv EnvIstance => new CartPoleEnv(AvaloniaEnvViewer.Run);
        public ImageStackLayout ImageStackLayout => ImageStackLayout.Horizontal;
        public int MemoryFrames => 2;
        public int SkippedFrames => 1;
        public int FrameWidth => 600;
        public int FrameHeight => 400;
        public int ScaledImageWidth => 50;
        public int ScaledImageHeight => 50;
        public float StartingEpsilon => 1;
        public int Episodes => 500;
        public int BatchSize => 100;
        public int Epochs => 10;
    }
}
