﻿using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Gym.Environments {
    /// <summary>
    ///     A delegate that creates a <see cref="IEnvViewer"/> with given parameters.
    /// </summary>
    /// <param name="width">The width of the rendering window.</param>
    /// <param name="height">The height of the rendering window.</param>
    /// <param name="title">The title of the rendering window.</param>
    /// <returns>A new environment viewer created based on parameters passed.</returns>
    public delegate IEnvViewer IEnvironmentViewerFactoryDelegate(int width, int height, string title = null);

    /// <summary>
    ///     Represents a graphics engine that is able to <see cref="Render"/> images.
    /// </summary>
    public interface IEnvViewer : IDisposable {
        /// <summary>
        ///     Render the given <paramref name="img"/>.
        /// </summary>
        /// <param name="img">The image to render.</param>
        void Render(Image<Rgba32> img);

        /// <summary>
        ///     Close the rendering window.
        /// </summary>
        void Close();
    }
}